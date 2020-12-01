# Voicify.Sdk.Analytics.Api.ConversationTrackingApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConversationTrackingTreeForApplication**](ConversationTrackingApi.md#getconversationtrackingtreeforapplication) | **GET** /api/ConversationTracking/application/{applicationId} | Generate a conversation tracking tree for an application
[**GetConversationTrackingTreeForContent**](ConversationTrackingApi.md#getconversationtrackingtreeforcontent) | **GET** /api/ConversationTracking/content/{applicationId}/{contentId} | Generate a conversation tracking tree for a specific piece of content


<a name="getconversationtrackingtreeforapplication"></a>
# **GetConversationTrackingTreeForApplication**
> ConversationTrackingTreeStartNode GetConversationTrackingTreeForApplication (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Generate a conversation tracking tree for an application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetConversationTrackingTreeForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConversationTrackingApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the range for the query
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the range for the query
            var locales = new List<string>(); // List<string> | An optional list of locales to filter request event data (optional) 
            var deviceTargetIds = new List<string>(); // List<string> | An optional list of device target IDs to filter requests by (optional) 
            var assistants = new List<string>(); // List<string> | An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. (optional) 
            var userIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of users (optional) 
            var sessionIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of sessions (optional) 

            try
            {
                // Generate a conversation tracking tree for an application
                ConversationTrackingTreeStartNode result = apiInstance.GetConversationTrackingTreeForApplication(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationTrackingApi.GetConversationTrackingTreeForApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **startDate** | **DateTime?**| The start date of the range for the query | 
 **endDate** | **DateTime?**| The end date of the range for the query | 
 **locales** | [**List&lt;string&gt;**](string.md)| An optional list of locales to filter request event data | [optional] 
 **deviceTargetIds** | [**List&lt;string&gt;**](string.md)| An optional list of device target IDs to filter requests by | [optional] 
 **assistants** | [**List&lt;string&gt;**](string.md)| An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of users | [optional] 
 **sessionIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of sessions | [optional] 

### Return type

[**ConversationTrackingTreeStartNode**](ConversationTrackingTreeStartNode.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationtrackingtreeforcontent"></a>
# **GetConversationTrackingTreeForContent**
> List<ConversationTrackingTreeBaseNode> GetConversationTrackingTreeForContent (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Generate a conversation tracking tree for a specific piece of content

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetConversationTrackingTreeForContentExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConversationTrackingApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the range for the query
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the range for the query
            var locales = new List<string>(); // List<string> | An optional list of locales to filter request event data (optional) 
            var deviceTargetIds = new List<string>(); // List<string> | An optional list of device target IDs to filter requests by (optional) 
            var assistants = new List<string>(); // List<string> | An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. (optional) 
            var userIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of users (optional) 
            var sessionIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of sessions (optional) 

            try
            {
                // Generate a conversation tracking tree for a specific piece of content
                List&lt;ConversationTrackingTreeBaseNode&gt; result = apiInstance.GetConversationTrackingTreeForContent(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationTrackingApi.GetConversationTrackingTreeForContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **contentId** | **string**|  | 
 **startDate** | **DateTime?**| The start date of the range for the query | 
 **endDate** | **DateTime?**| The end date of the range for the query | 
 **locales** | [**List&lt;string&gt;**](string.md)| An optional list of locales to filter request event data | [optional] 
 **deviceTargetIds** | [**List&lt;string&gt;**](string.md)| An optional list of device target IDs to filter requests by | [optional] 
 **assistants** | [**List&lt;string&gt;**](string.md)| An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of users | [optional] 
 **sessionIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of sessions | [optional] 

### Return type

[**List<ConversationTrackingTreeBaseNode>**](ConversationTrackingTreeBaseNode.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

