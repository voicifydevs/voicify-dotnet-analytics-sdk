using System;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;
using System.Linq;
using System.Threading.Tasks;
using Voicify.Sdk.Core.Models.Constants;

namespace Voicify.Samples.Assistant.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Uri appUri = null;
            string appId = null;
            string appSecret = null;
            while (appUri == null || appId == null || appSecret == null)
            {
                Console.WriteLine("Welcome to the NEW MODIFIED BULK Voicify Assistant Sample App!");
                Console.WriteLine("Enter your \"Custom Assistant\" fulfillment URL for the app you want to use. You can find it in your app settings in the Voicify CMS");
                var url = Console.ReadLine();
                var validUrl = Uri.TryCreate(url, UriKind.Absolute, out appUri);
                if (!validUrl)
                {
                    Console.WriteLine("Invalid URL. Try a different one");
                }
                else
                {
                    var queryParams = appUri.Query
                      .Substring(1) // Remove '?'
                      .Split('&')
                      .Select(q => q.Split('='))
                      .ToDictionary(q => q.FirstOrDefault(), q => q.Skip(1).FirstOrDefault());

                    if (queryParams.ContainsKey("applicationId"))
                        appId = queryParams["applicationId"];
                    if (queryParams.ContainsKey("applicationSecret"))
                        appSecret = queryParams["applicationSecret"];
                }
            }

            Console.WriteLine("Enter how many copies of the same request you want to send");
            var count = Console.ReadLine();
            var requestCount = int.Parse(count);


            var customAssistantApi = new CustomAssistantApi(new Configuration
            {
                BasePath = $"https://{appUri.Host}"
            });

            var device = new CustomAssistantDevice(
                id: Guid.NewGuid().ToString(),
                name: "Voicify Sample Console App",
                supportsDisplayText: true,
                supportsTextInput: true
            );
            var user = new CustomAssistantUser(
                id: Guid.NewGuid().ToString(),
                name: "Console User"
            );

            Console.WriteLine("Requesting app's welcome message...");
            var welcomeContext = CreateContext(string.Empty);
            welcomeContext.RequiresLanguageUnderstanding = false;
            welcomeContext.RequestName = CustomAssistantIntents.VoicifyWelcome;
            var welcomeResponse = await customAssistantApi.HandleRequestAsync(appId, appSecret, new CustomAssistantRequestBody(
                requestId: Guid.NewGuid().ToString(),
                device: device,
                user: user,
                context: welcomeContext
            ));

            Console.WriteLine(welcomeResponse.OutputSpeech);
            Console.WriteLine("...");

            CustomAssistantResponse response = null;
            while (response?.EndSession != true)
            {
                var input = Console.ReadLine();
                Console.WriteLine("...");
                for (var i = 0; i < requestCount; i++)
                {
                    response = await customAssistantApi.HandleRequestAsync(appId, appSecret, new CustomAssistantRequestBody(
                        requestId: Guid.NewGuid().ToString(),
                        device: device,
                        user: user,
                        context: CreateContext(input)));
                    Console.WriteLine(response.OutputSpeech);
                }

                Console.WriteLine("...");
            }

            Console.WriteLine("That's all! To start a new session, restart this app");
            Console.ReadLine();
        }

        static CustomAssistantRequestContext CreateContext(string input)
        {
            return new CustomAssistantRequestContext(
                channel: "Voicify Console App",
                locale: "en-US",
                sessionId: Guid.NewGuid().ToString(),
                requestType: "IntentRequest",
                originalInput: input,
                requiresLanguageUnderstanding: true
            );
        }
    }
}
