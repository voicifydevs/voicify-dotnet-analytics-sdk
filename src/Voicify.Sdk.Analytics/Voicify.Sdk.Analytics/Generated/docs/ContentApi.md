# Voicify.Sdk.Analytics.Api.ContentApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApplicationUsageTotals**](ContentApi.md#getapplicationusagetotals) | **GET** /api/v2/Content/{applicationId}/{contentId}/totals/usage | Gets the total usage counts for the given content item
[**GetInteractionsAggregatedByAssistant**](ContentApi.md#getinteractionsaggregatedbyassistant) | **GET** /api/v2/Content/{applicationId}/{contentId}/interactions/aggregation/assistant | Get a count of content-level interactions grouped by assistant
[**GetInteractionsAggregatedByDeviceTarget**](ContentApi.md#getinteractionsaggregatedbydevicetarget) | **GET** /api/v2/Content/{applicationId}/{contentId}/interactions/aggregation/deviceTarget | Get a count of content-level interactions grouped by device target
[**GetInteractionsAggregatedByInterfaceType**](ContentApi.md#getinteractionsaggregatedbyinterfacetype) | **GET** /api/v2/Content/{applicationId}/{contentId}/interactions/aggregation/interfaceType | Get a count of content-level interactions grouped by interface type (e.g. screen, audio, chat)
[**GetInteractionsAggregatedByLocale**](ContentApi.md#getinteractionsaggregatedbylocale) | **GET** /api/v2/Content/{applicationId}/{contentId}/interactions/aggregation/locale | Get a count of content-level interactions grouped by locale
[**GetInteractionsHistogram**](ContentApi.md#getinteractionshistogram) | **GET** /api/v2/Content/{applicationId}/{contentId}/interactions/histogram | Get a histogram of content-level interactions (raw requests)
[**GetNewUsersAggregatedByAssistant**](ContentApi.md#getnewusersaggregatedbyassistant) | **GET** /api/v2/Content/{applicationId}/{contentId}/newUsers/aggregation/assistant | Get new user count for content item grouped by assistant
[**GetNewUsersAggregatedByDeviceTarget**](ContentApi.md#getnewusersaggregatedbydevicetarget) | **GET** /api/v2/Content/{applicationId}/{contentId}/newUsers/aggregation/deviceTarget | Get new user count for content item grouped by device target
[**GetNewUsersAggregatedByInterface**](ContentApi.md#getnewusersaggregatedbyinterface) | **GET** /api/v2/Content/{applicationId}/{contentId}/newUsers/aggregation/interfaceType | Get new user count for content item grouped by interface (e.g. screen, audio, chat)
[**GetNewUsersAggregatedByLocale**](ContentApi.md#getnewusersaggregatedbylocale) | **GET** /api/v2/Content/{applicationId}/{contentId}/newUsers/aggregation/locale | Get new user count for content item grouped by locale
[**GetNewUsersHistogram**](ContentApi.md#getnewusershistogram) | **GET** /api/v2/Content/{applicationId}/{contentId}/newUsers/histogram | Get histogram of new users
[**GetSessionsAggregatedByAssistant**](ContentApi.md#getsessionsaggregatedbyassistant) | **GET** /api/v2/Content/{applicationId}/{contentId}/sessions/aggregation/assistant | Get a count of content-level sessions grouped by assistant platform
[**GetSessionsAggregatedByDeviceTarget**](ContentApi.md#getsessionsaggregatedbydevicetarget) | **GET** /api/v2/Content/{applicationId}/{contentId}/sessions/aggregation/deviceTarget | Get a count of content-level sessions grouped by device target
[**GetSessionsAggregatedByInterfaceType**](ContentApi.md#getsessionsaggregatedbyinterfacetype) | **GET** /api/v2/Content/{applicationId}/{contentId}/sessions/aggregation/interfaceType | Get a count of content-level sessions grouped by interface type (e.g. screen, audio, chat)
[**GetSessionsAggregatedByLocale**](ContentApi.md#getsessionsaggregatedbylocale) | **GET** /api/v2/Content/{applicationId}/{contentId}/sessions/aggregation/locale | Get a count of content-level sessions grouped by locale
[**GetSessionsHistogram**](ContentApi.md#getsessionshistogram) | **GET** /api/v2/Content/{applicationId}/{contentId}/sessions/histogram | Get a histogram of sessions
[**GetUsersAggregatedByAssistant**](ContentApi.md#getusersaggregatedbyassistant) | **GET** /api/v2/Content/{applicationId}/{contentId}/users/aggregation/assistant | Get content-level user count grouped by assistant
[**GetUsersAggregatedByDeviceTarget**](ContentApi.md#getusersaggregatedbydevicetarget) | **GET** /api/v2/Content/{applicationId}/{contentId}/users/aggregation/deviceTarget | Get content-level user count grouped by device target
[**GetUsersAggregatedByInterface**](ContentApi.md#getusersaggregatedbyinterface) | **GET** /api/v2/Content/{applicationId}/{contentId}/users/aggregation/interfaceType | Get content-level user count grouped by interface (e.g. screen, audio, chat)
[**GetUsersAggregatedByLocale**](ContentApi.md#getusersaggregatedbylocale) | **GET** /api/v2/Content/{applicationId}/{contentId}/users/aggregation/locale | Get content-level user count grouped by locale
[**GetUsersHistogram**](ContentApi.md#getusershistogram) | **GET** /api/v2/Content/{applicationId}/{contentId}/users/histogram | Get user histogram


<a name="getapplicationusagetotals"></a>
# **GetApplicationUsageTotals**
> ApplicationStatisticsModel GetApplicationUsageTotals (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Gets the total usage counts for the given content item

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationUsageTotalsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Gets the total usage counts for the given content item
                ApplicationStatisticsModel result = apiInstance.GetApplicationUsageTotals(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetApplicationUsageTotals: " + e.Message );
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

[**ApplicationStatisticsModel**](ApplicationStatisticsModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionsaggregatedbyassistant"></a>
# **GetInteractionsAggregatedByAssistant**
> List<AssistantUsageModel> GetInteractionsAggregatedByAssistant (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of content-level interactions grouped by assistant

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetInteractionsAggregatedByAssistantExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get a count of content-level interactions grouped by assistant
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetInteractionsAggregatedByAssistant(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetInteractionsAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionsaggregatedbydevicetarget"></a>
# **GetInteractionsAggregatedByDeviceTarget**
> List<DeviceTargetUsageModel> GetInteractionsAggregatedByDeviceTarget (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of content-level interactions grouped by device target

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetInteractionsAggregatedByDeviceTargetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get a count of content-level interactions grouped by device target
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetInteractionsAggregatedByDeviceTarget(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetInteractionsAggregatedByDeviceTarget: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionsaggregatedbyinterfacetype"></a>
# **GetInteractionsAggregatedByInterfaceType**
> List<InterfaceUsageModel> GetInteractionsAggregatedByInterfaceType (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of content-level interactions grouped by interface type (e.g. screen, audio, chat)

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetInteractionsAggregatedByInterfaceTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get a count of content-level interactions grouped by interface type (e.g. screen, audio, chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetInteractionsAggregatedByInterfaceType(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetInteractionsAggregatedByInterfaceType: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionsaggregatedbylocale"></a>
# **GetInteractionsAggregatedByLocale**
> List<LocaleUsageModel> GetInteractionsAggregatedByLocale (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of content-level interactions grouped by locale

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetInteractionsAggregatedByLocaleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get a count of content-level interactions grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetInteractionsAggregatedByLocale(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetInteractionsAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionshistogram"></a>
# **GetInteractionsHistogram**
> List<DatedUsageModel> GetInteractionsHistogram (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a histogram of content-level interactions (raw requests)

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetInteractionsHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the range for the query
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the range for the query
            var interval = interval_example;  // string |  (optional) 
            var locales = new List<string>(); // List<string> | An optional list of locales to filter request event data (optional) 
            var deviceTargetIds = new List<string>(); // List<string> | An optional list of device target IDs to filter requests by (optional) 
            var assistants = new List<string>(); // List<string> | An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. (optional) 
            var userIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of users (optional) 
            var sessionIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of sessions (optional) 

            try
            {
                // Get a histogram of content-level interactions (raw requests)
                List&lt;DatedUsageModel&gt; result = apiInstance.GetInteractionsHistogram(applicationId, contentId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetInteractionsHistogram: " + e.Message );
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
 **interval** | **string**|  | [optional] 
 **locales** | [**List&lt;string&gt;**](string.md)| An optional list of locales to filter request event data | [optional] 
 **deviceTargetIds** | [**List&lt;string&gt;**](string.md)| An optional list of device target IDs to filter requests by | [optional] 
 **assistants** | [**List&lt;string&gt;**](string.md)| An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of users | [optional] 
 **sessionIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of sessions | [optional] 

### Return type

[**List<DatedUsageModel>**](DatedUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusersaggregatedbyassistant"></a>
# **GetNewUsersAggregatedByAssistant**
> List<AssistantUsageModel> GetNewUsersAggregatedByAssistant (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get new user count for content item grouped by assistant

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetNewUsersAggregatedByAssistantExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get new user count for content item grouped by assistant
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetNewUsersAggregatedByAssistant(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetNewUsersAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusersaggregatedbydevicetarget"></a>
# **GetNewUsersAggregatedByDeviceTarget**
> List<DeviceTargetUsageModel> GetNewUsersAggregatedByDeviceTarget (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get new user count for content item grouped by device target

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetNewUsersAggregatedByDeviceTargetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get new user count for content item grouped by device target
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetNewUsersAggregatedByDeviceTarget(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetNewUsersAggregatedByDeviceTarget: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusersaggregatedbyinterface"></a>
# **GetNewUsersAggregatedByInterface**
> List<InterfaceUsageModel> GetNewUsersAggregatedByInterface (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get new user count for content item grouped by interface (e.g. screen, audio, chat)

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetNewUsersAggregatedByInterfaceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get new user count for content item grouped by interface (e.g. screen, audio, chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetNewUsersAggregatedByInterface(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetNewUsersAggregatedByInterface: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusersaggregatedbylocale"></a>
# **GetNewUsersAggregatedByLocale**
> List<LocaleUsageModel> GetNewUsersAggregatedByLocale (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get new user count for content item grouped by locale

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetNewUsersAggregatedByLocaleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get new user count for content item grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetNewUsersAggregatedByLocale(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetNewUsersAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusershistogram"></a>
# **GetNewUsersHistogram**
> List<DatedUsageModel> GetNewUsersHistogram (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get histogram of new users

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetNewUsersHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the range for the query
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the range for the query
            var interval = interval_example;  // string |  (optional) 
            var locales = new List<string>(); // List<string> | An optional list of locales to filter request event data (optional) 
            var deviceTargetIds = new List<string>(); // List<string> | An optional list of device target IDs to filter requests by (optional) 
            var assistants = new List<string>(); // List<string> | An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. (optional) 
            var userIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of users (optional) 
            var sessionIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of sessions (optional) 

            try
            {
                // Get histogram of new users
                List&lt;DatedUsageModel&gt; result = apiInstance.GetNewUsersHistogram(applicationId, contentId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetNewUsersHistogram: " + e.Message );
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
 **interval** | **string**|  | [optional] 
 **locales** | [**List&lt;string&gt;**](string.md)| An optional list of locales to filter request event data | [optional] 
 **deviceTargetIds** | [**List&lt;string&gt;**](string.md)| An optional list of device target IDs to filter requests by | [optional] 
 **assistants** | [**List&lt;string&gt;**](string.md)| An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of users | [optional] 
 **sessionIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of sessions | [optional] 

### Return type

[**List<DatedUsageModel>**](DatedUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionsaggregatedbyassistant"></a>
# **GetSessionsAggregatedByAssistant**
> List<AssistantUsageModel> GetSessionsAggregatedByAssistant (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of content-level sessions grouped by assistant platform

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetSessionsAggregatedByAssistantExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get a count of content-level sessions grouped by assistant platform
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetSessionsAggregatedByAssistant(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetSessionsAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionsaggregatedbydevicetarget"></a>
# **GetSessionsAggregatedByDeviceTarget**
> List<DeviceTargetUsageModel> GetSessionsAggregatedByDeviceTarget (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of content-level sessions grouped by device target

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetSessionsAggregatedByDeviceTargetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get a count of content-level sessions grouped by device target
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetSessionsAggregatedByDeviceTarget(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetSessionsAggregatedByDeviceTarget: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionsaggregatedbyinterfacetype"></a>
# **GetSessionsAggregatedByInterfaceType**
> List<InterfaceUsageModel> GetSessionsAggregatedByInterfaceType (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of content-level sessions grouped by interface type (e.g. screen, audio, chat)

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetSessionsAggregatedByInterfaceTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get a count of content-level sessions grouped by interface type (e.g. screen, audio, chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetSessionsAggregatedByInterfaceType(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetSessionsAggregatedByInterfaceType: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionsaggregatedbylocale"></a>
# **GetSessionsAggregatedByLocale**
> List<LocaleUsageModel> GetSessionsAggregatedByLocale (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of content-level sessions grouped by locale

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetSessionsAggregatedByLocaleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get a count of content-level sessions grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetSessionsAggregatedByLocale(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetSessionsAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionshistogram"></a>
# **GetSessionsHistogram**
> List<DatedUsageModel> GetSessionsHistogram (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a histogram of sessions

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetSessionsHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the range for the query
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the range for the query
            var interval = interval_example;  // string |  (optional) 
            var locales = new List<string>(); // List<string> | An optional list of locales to filter request event data (optional) 
            var deviceTargetIds = new List<string>(); // List<string> | An optional list of device target IDs to filter requests by (optional) 
            var assistants = new List<string>(); // List<string> | An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. (optional) 
            var userIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of users (optional) 
            var sessionIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of sessions (optional) 

            try
            {
                // Get a histogram of sessions
                List&lt;DatedUsageModel&gt; result = apiInstance.GetSessionsHistogram(applicationId, contentId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetSessionsHistogram: " + e.Message );
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
 **interval** | **string**|  | [optional] 
 **locales** | [**List&lt;string&gt;**](string.md)| An optional list of locales to filter request event data | [optional] 
 **deviceTargetIds** | [**List&lt;string&gt;**](string.md)| An optional list of device target IDs to filter requests by | [optional] 
 **assistants** | [**List&lt;string&gt;**](string.md)| An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of users | [optional] 
 **sessionIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of sessions | [optional] 

### Return type

[**List<DatedUsageModel>**](DatedUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersaggregatedbyassistant"></a>
# **GetUsersAggregatedByAssistant**
> List<AssistantUsageModel> GetUsersAggregatedByAssistant (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get content-level user count grouped by assistant

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetUsersAggregatedByAssistantExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get content-level user count grouped by assistant
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetUsersAggregatedByAssistant(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetUsersAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersaggregatedbydevicetarget"></a>
# **GetUsersAggregatedByDeviceTarget**
> List<DeviceTargetUsageModel> GetUsersAggregatedByDeviceTarget (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get content-level user count grouped by device target

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetUsersAggregatedByDeviceTargetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get content-level user count grouped by device target
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetUsersAggregatedByDeviceTarget(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetUsersAggregatedByDeviceTarget: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersaggregatedbyinterface"></a>
# **GetUsersAggregatedByInterface**
> List<InterfaceUsageModel> GetUsersAggregatedByInterface (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get content-level user count grouped by interface (e.g. screen, audio, chat)

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetUsersAggregatedByInterfaceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get content-level user count grouped by interface (e.g. screen, audio, chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetUsersAggregatedByInterface(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetUsersAggregatedByInterface: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersaggregatedbylocale"></a>
# **GetUsersAggregatedByLocale**
> List<LocaleUsageModel> GetUsersAggregatedByLocale (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get content-level user count grouped by locale

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetUsersAggregatedByLocaleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
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
                // Get content-level user count grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetUsersAggregatedByLocale(applicationId, contentId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetUsersAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusershistogram"></a>
# **GetUsersHistogram**
> List<DatedUsageModel> GetUsersHistogram (string applicationId, string contentId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get user histogram

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetUsersHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the range for the query
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the range for the query
            var interval = interval_example;  // string |  (optional) 
            var locales = new List<string>(); // List<string> | An optional list of locales to filter request event data (optional) 
            var deviceTargetIds = new List<string>(); // List<string> | An optional list of device target IDs to filter requests by (optional) 
            var assistants = new List<string>(); // List<string> | An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. (optional) 
            var userIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of users (optional) 
            var sessionIds = new List<string>(); // List<string> | An optional list of user IDs to filter by. This will scope all data to the specific set of sessions (optional) 

            try
            {
                // Get user histogram
                List&lt;DatedUsageModel&gt; result = apiInstance.GetUsersHistogram(applicationId, contentId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.GetUsersHistogram: " + e.Message );
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
 **interval** | **string**|  | [optional] 
 **locales** | [**List&lt;string&gt;**](string.md)| An optional list of locales to filter request event data | [optional] 
 **deviceTargetIds** | [**List&lt;string&gt;**](string.md)| An optional list of device target IDs to filter requests by | [optional] 
 **assistants** | [**List&lt;string&gt;**](string.md)| An optional list of platforms to filter by. Ex: Alexa, GoogleAssistant, Bixby, MyCustomPlatform, etc. | [optional] 
 **userIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of users | [optional] 
 **sessionIds** | [**List&lt;string&gt;**](string.md)| An optional list of user IDs to filter by. This will scope all data to the specific set of sessions | [optional] 

### Return type

[**List<DatedUsageModel>**](DatedUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

