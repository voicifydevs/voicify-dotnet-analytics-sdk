# Voicify.Sdk.Analytics.Api.ApplicationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApplicationAssistants**](ApplicationApi.md#getapplicationassistants) | **GET** /api/v2/Application/{applicationId}/unique/assistants | Gets the unique assistant platforms used within the given time period
[**GetApplicationMissTotals**](ApplicationApi.md#getapplicationmisstotals) | **GET** /api/v2/Application/{applicationId}/totals/misses | Gets the total miss counts for the given application
[**GetApplicationTopHits**](ApplicationApi.md#getapplicationtophits) | **GET** /api/v2/Application/{applicationId}/totals/top/hits | Gets the top content item hits for the given application
[**GetApplicationTopMisses**](ApplicationApi.md#getapplicationtopmisses) | **GET** /api/v2/Application/{applicationId}/totals/top/misses | Gets the top content item misses for the given application
[**GetApplicationUsageTotals**](ApplicationApi.md#getapplicationusagetotals) | **GET** /api/v2/Application/{applicationId}/totals/usage | Gets the total usage counts for the given application
[**GetContentMissesAggregatedByAssistant**](ApplicationApi.md#getcontentmissesaggregatedbyassistant) | **GET** /api/v2/Application/{applicationId}/contentMisses/aggregation/assistant | Get a count of missed requests grouped by assistant platform
[**GetContentMissesAggregatedByDeviceType**](ApplicationApi.md#getcontentmissesaggregatedbydevicetype) | **GET** /api/v2/Application/{applicationId}/contentMisses/aggregation/deviceTarget | Get a count of missed requests grouped by device type
[**GetContentMissesAggregatedByFeatureType**](ApplicationApi.md#getcontentmissesaggregatedbyfeaturetype) | **GET** /api/v2/Application/{applicationId}/contentMisses/aggregation/featureType | Get a count of missed requests grouped by feature type
[**GetContentMissesAggregatedByInterfaceType**](ApplicationApi.md#getcontentmissesaggregatedbyinterfacetype) | **GET** /api/v2/Application/{applicationId}/contentMisses/aggregation/interfaceType | Get a count of missed requests grouped by interface type (e.g. Audio, Screen, Chat)
[**GetContentMissesAggregatedByLocale**](ApplicationApi.md#getcontentmissesaggregatedbylocale) | **GET** /api/v2/Application/{applicationId}/contentMisses/aggregation/locale | Get a count of missed requests grouped by locale
[**GetContentMissesHistogram**](ApplicationApi.md#getcontentmisseshistogram) | **GET** /api/v2/Application/{applicationId}/contentMisses/histogram | Get a histogram of missed requests
[**GetFeatureMissesAggregatedByAssistant**](ApplicationApi.md#getfeaturemissesaggregatedbyassistant) | **GET** /api/v2/Application/{applicationId}/featureMisses/aggregation/assistant | Get a count of missed features grouped by assistant platform
[**GetFeatureMissesAggregatedByDeviceType**](ApplicationApi.md#getfeaturemissesaggregatedbydevicetype) | **GET** /api/v2/Application/{applicationId}/featureMisses/aggregation/deviceTarget | Get a count of missed features grouped by device type
[**GetFeatureMissesAggregatedByInterfaceType**](ApplicationApi.md#getfeaturemissesaggregatedbyinterfacetype) | **GET** /api/v2/Application/{applicationId}/featureMisses/aggregation/interfaceType | Get a count of missed features grouped by interface type (e.g. Audio, Screen, Chat)
[**GetFeatureMissesAggregatedByLocale**](ApplicationApi.md#getfeaturemissesaggregatedbylocale) | **GET** /api/v2/Application/{applicationId}/featureMisses/aggregation/locale | Get a count of missed features grouped by locale
[**GetFeatureMissesHistogram**](ApplicationApi.md#getfeaturemisseshistogram) | **GET** /api/v2/Application/{applicationId}/featureMisses/histogram | Get a histogram of missed features
[**GetInteractionsAggregatedByAssistant**](ApplicationApi.md#getinteractionsaggregatedbyassistant) | **GET** /api/v2/Application/{applicationId}/interactions/aggregation/assistant | Get a count of interactions grouped by assistant
[**GetInteractionsAggregatedByDeviceTarget**](ApplicationApi.md#getinteractionsaggregatedbydevicetarget) | **GET** /api/v2/Application/{applicationId}/interactions/aggregation/deviceTarget | Get a count of interactions grouped by device target
[**GetInteractionsAggregatedByFeatureType**](ApplicationApi.md#getinteractionsaggregatedbyfeaturetype) | **GET** /api/v2/Application/{applicationId}/interactions/aggregation/featureType | Get a count of interactions grouped by featureType
[**GetInteractionsAggregatedByInterfaceType**](ApplicationApi.md#getinteractionsaggregatedbyinterfacetype) | **GET** /api/v2/Application/{applicationId}/interactions/aggregation/interfaceType | Get a count of interactions grouped by interface type (e.g. screen, audio, chat)
[**GetInteractionsAggregatedByLocale**](ApplicationApi.md#getinteractionsaggregatedbylocale) | **GET** /api/v2/Application/{applicationId}/interactions/aggregation/locale | Get a count of interactions grouped by locale
[**GetInteractionsHistogram**](ApplicationApi.md#getinteractionshistogram) | **GET** /api/v2/Application/{applicationId}/interactions/histogram | Get a histogram of interactions (raw requests)
[**GetNewUsersAggregatedByAssistant**](ApplicationApi.md#getnewusersaggregatedbyassistant) | **GET** /api/v2/Application/{applicationId}/newUsers/aggregation/assistant | Get new user count for application grouped by assistant
[**GetNewUsersAggregatedByDeviceTarget**](ApplicationApi.md#getnewusersaggregatedbydevicetarget) | **GET** /api/v2/Application/{applicationId}/newUsers/aggregation/deviceTarget | Get new user count for application grouped by device target
[**GetNewUsersAggregatedByFeatureType**](ApplicationApi.md#getnewusersaggregatedbyfeaturetype) | **GET** /api/v2/Application/{applicationId}/newUsers/aggregation/featureType | Get new user count for application grouped by feature type
[**GetNewUsersAggregatedByInterface**](ApplicationApi.md#getnewusersaggregatedbyinterface) | **GET** /api/v2/Application/{applicationId}/newUsers/aggregation/interfaceType | Get new user count for application grouped by interface (e.g. screen, audio, chat)
[**GetNewUsersAggregatedByLocale**](ApplicationApi.md#getnewusersaggregatedbylocale) | **GET** /api/v2/Application/{applicationId}/newUsers/aggregation/locale | Get new user count for application grouped by locale
[**GetNewUsersHistogram**](ApplicationApi.md#getnewusershistogram) | **GET** /api/v2/Application/{applicationId}/newUsers/histogram | Get histogram of new users
[**GetSessionsAggregatedByAssistant**](ApplicationApi.md#getsessionsaggregatedbyassistant) | **GET** /api/v2/Application/{applicationId}/sessions/aggregation/assistant | Get a count of sessions grouped by assistant platform
[**GetSessionsAggregatedByDeviceTarget**](ApplicationApi.md#getsessionsaggregatedbydevicetarget) | **GET** /api/v2/Application/{applicationId}/sessions/aggregation/deviceTarget | Get a count of sessions grouped by device target
[**GetSessionsAggregatedByFeatureType**](ApplicationApi.md#getsessionsaggregatedbyfeaturetype) | **GET** /api/v2/Application/{applicationId}/sessions/aggregation/featureType | Gets a count of sessions grouped by feature type
[**GetSessionsAggregatedByInterfaceType**](ApplicationApi.md#getsessionsaggregatedbyinterfacetype) | **GET** /api/v2/Application/{applicationId}/sessions/aggregation/interfaceType | Get a count of sessions grouped by interface type (e.g. screen, audio, chat)
[**GetSessionsAggregatedByLocale**](ApplicationApi.md#getsessionsaggregatedbylocale) | **GET** /api/v2/Application/{applicationId}/sessions/aggregation/locale | Get a count of sessions grouped by locale
[**GetSessionsHistogram**](ApplicationApi.md#getsessionshistogram) | **GET** /api/v2/Application/{applicationId}/sessions/histogram | Get a histogram of sessions
[**GetUsersAggregatedByAssistant**](ApplicationApi.md#getusersaggregatedbyassistant) | **GET** /api/v2/Application/{applicationId}/users/aggregation/assistant | Get application user count grouped by assistant
[**GetUsersAggregatedByDeviceTarget**](ApplicationApi.md#getusersaggregatedbydevicetarget) | **GET** /api/v2/Application/{applicationId}/users/aggregation/deviceTarget | Get application user count grouped by device target
[**GetUsersAggregatedByFeatureType**](ApplicationApi.md#getusersaggregatedbyfeaturetype) | **GET** /api/v2/Application/{applicationId}/users/aggregation/featureType | Get application user count grouped by feature type
[**GetUsersAggregatedByInterface**](ApplicationApi.md#getusersaggregatedbyinterface) | **GET** /api/v2/Application/{applicationId}/users/aggregation/interfaceType | Get application user count grouped by interface (e.g. screen, audio, chat)
[**GetUsersAggregatedByLocale**](ApplicationApi.md#getusersaggregatedbylocale) | **GET** /api/v2/Application/{applicationId}/users/aggregation/locale | Get application user count grouped by locale
[**GetUsersHistogram**](ApplicationApi.md#getusershistogram) | **GET** /api/v2/Application/{applicationId}/users/histogram | Get user histogram


<a name="getapplicationassistants"></a>
# **GetApplicationAssistants**
> List<string> GetApplicationAssistants (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Gets the unique assistant platforms used within the given time period

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationAssistantsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Gets the unique assistant platforms used within the given time period
                List&lt;string&gt; result = apiInstance.GetApplicationAssistants(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationAssistants: " + e.Message );
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

**List<string>**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationmisstotals"></a>
# **GetApplicationMissTotals**
> ApplicationMissStatisticsModel GetApplicationMissTotals (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Gets the total miss counts for the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationMissTotalsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Gets the total miss counts for the given application
                ApplicationMissStatisticsModel result = apiInstance.GetApplicationMissTotals(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationMissTotals: " + e.Message );
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

[**ApplicationMissStatisticsModel**](ApplicationMissStatisticsModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationtophits"></a>
# **GetApplicationTopHits**
> TopContentHitModel GetApplicationTopHits (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Gets the top content item hits for the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationTopHitsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Gets the top content item hits for the given application
                TopContentHitModel result = apiInstance.GetApplicationTopHits(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationTopHits: " + e.Message );
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

[**TopContentHitModel**](TopContentHitModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationtopmisses"></a>
# **GetApplicationTopMisses**
> TopContentMissModel GetApplicationTopMisses (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Gets the top content item misses for the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationTopMissesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Gets the top content item misses for the given application
                TopContentMissModel result = apiInstance.GetApplicationTopMisses(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationTopMisses: " + e.Message );
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

[**TopContentMissModel**](TopContentMissModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationusagetotals"></a>
# **GetApplicationUsageTotals**
> ApplicationStatisticsModel GetApplicationUsageTotals (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Gets the total usage counts for the given application

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

            var apiInstance = new ApplicationApi();
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
                // Gets the total usage counts for the given application
                ApplicationStatisticsModel result = apiInstance.GetApplicationUsageTotals(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationUsageTotals: " + e.Message );
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

[**ApplicationStatisticsModel**](ApplicationStatisticsModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentmissesaggregatedbyassistant"></a>
# **GetContentMissesAggregatedByAssistant**
> List<AssistantUsageModel> GetContentMissesAggregatedByAssistant (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of missed requests grouped by assistant platform

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetContentMissesAggregatedByAssistantExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of missed requests grouped by assistant platform
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetContentMissesAggregatedByAssistant(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetContentMissesAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentmissesaggregatedbydevicetype"></a>
# **GetContentMissesAggregatedByDeviceType**
> List<DeviceTargetUsageModel> GetContentMissesAggregatedByDeviceType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of missed requests grouped by device type

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetContentMissesAggregatedByDeviceTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of missed requests grouped by device type
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetContentMissesAggregatedByDeviceType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetContentMissesAggregatedByDeviceType: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentmissesaggregatedbyfeaturetype"></a>
# **GetContentMissesAggregatedByFeatureType**
> List<FeatureUsageModel> GetContentMissesAggregatedByFeatureType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of missed requests grouped by feature type

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetContentMissesAggregatedByFeatureTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of missed requests grouped by feature type
                List&lt;FeatureUsageModel&gt; result = apiInstance.GetContentMissesAggregatedByFeatureType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetContentMissesAggregatedByFeatureType: " + e.Message );
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

[**List<FeatureUsageModel>**](FeatureUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentmissesaggregatedbyinterfacetype"></a>
# **GetContentMissesAggregatedByInterfaceType**
> List<InterfaceUsageModel> GetContentMissesAggregatedByInterfaceType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of missed requests grouped by interface type (e.g. Audio, Screen, Chat)

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetContentMissesAggregatedByInterfaceTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of missed requests grouped by interface type (e.g. Audio, Screen, Chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetContentMissesAggregatedByInterfaceType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetContentMissesAggregatedByInterfaceType: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentmissesaggregatedbylocale"></a>
# **GetContentMissesAggregatedByLocale**
> List<LocaleUsageModel> GetContentMissesAggregatedByLocale (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of missed requests grouped by locale

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetContentMissesAggregatedByLocaleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of missed requests grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetContentMissesAggregatedByLocale(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetContentMissesAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontentmisseshistogram"></a>
# **GetContentMissesHistogram**
> List<DatedUsageModel> GetContentMissesHistogram (string applicationId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a histogram of missed requests

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetContentMissesHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
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
                // Get a histogram of missed requests
                List&lt;DatedUsageModel&gt; result = apiInstance.GetContentMissesHistogram(applicationId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetContentMissesHistogram: " + e.Message );
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

<a name="getfeaturemissesaggregatedbyassistant"></a>
# **GetFeatureMissesAggregatedByAssistant**
> List<AssistantUsageModel> GetFeatureMissesAggregatedByAssistant (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of missed features grouped by assistant platform

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetFeatureMissesAggregatedByAssistantExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of missed features grouped by assistant platform
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetFeatureMissesAggregatedByAssistant(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetFeatureMissesAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeaturemissesaggregatedbydevicetype"></a>
# **GetFeatureMissesAggregatedByDeviceType**
> List<DeviceTargetUsageModel> GetFeatureMissesAggregatedByDeviceType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of missed features grouped by device type

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetFeatureMissesAggregatedByDeviceTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of missed features grouped by device type
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetFeatureMissesAggregatedByDeviceType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetFeatureMissesAggregatedByDeviceType: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeaturemissesaggregatedbyinterfacetype"></a>
# **GetFeatureMissesAggregatedByInterfaceType**
> List<InterfaceUsageModel> GetFeatureMissesAggregatedByInterfaceType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of missed features grouped by interface type (e.g. Audio, Screen, Chat)

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetFeatureMissesAggregatedByInterfaceTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of missed features grouped by interface type (e.g. Audio, Screen, Chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetFeatureMissesAggregatedByInterfaceType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetFeatureMissesAggregatedByInterfaceType: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeaturemissesaggregatedbylocale"></a>
# **GetFeatureMissesAggregatedByLocale**
> List<LocaleUsageModel> GetFeatureMissesAggregatedByLocale (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of missed features grouped by locale

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetFeatureMissesAggregatedByLocaleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of missed features grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetFeatureMissesAggregatedByLocale(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetFeatureMissesAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeaturemisseshistogram"></a>
# **GetFeatureMissesHistogram**
> List<DatedUsageModel> GetFeatureMissesHistogram (string applicationId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a histogram of missed features

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetFeatureMissesHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
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
                // Get a histogram of missed features
                List&lt;DatedUsageModel&gt; result = apiInstance.GetFeatureMissesHistogram(applicationId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetFeatureMissesHistogram: " + e.Message );
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

<a name="getinteractionsaggregatedbyassistant"></a>
# **GetInteractionsAggregatedByAssistant**
> List<AssistantUsageModel> GetInteractionsAggregatedByAssistant (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of interactions grouped by assistant

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

            var apiInstance = new ApplicationApi();
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
                // Get a count of interactions grouped by assistant
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetInteractionsAggregatedByAssistant(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetInteractionsAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionsaggregatedbydevicetarget"></a>
# **GetInteractionsAggregatedByDeviceTarget**
> List<DeviceTargetUsageModel> GetInteractionsAggregatedByDeviceTarget (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of interactions grouped by device target

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

            var apiInstance = new ApplicationApi();
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
                // Get a count of interactions grouped by device target
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetInteractionsAggregatedByDeviceTarget(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetInteractionsAggregatedByDeviceTarget: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionsaggregatedbyfeaturetype"></a>
# **GetInteractionsAggregatedByFeatureType**
> List<InterfaceUsageModel> GetInteractionsAggregatedByFeatureType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of interactions grouped by featureType

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetInteractionsAggregatedByFeatureTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get a count of interactions grouped by featureType
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetInteractionsAggregatedByFeatureType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetInteractionsAggregatedByFeatureType: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionsaggregatedbyinterfacetype"></a>
# **GetInteractionsAggregatedByInterfaceType**
> List<InterfaceUsageModel> GetInteractionsAggregatedByInterfaceType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of interactions grouped by interface type (e.g. screen, audio, chat)

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

            var apiInstance = new ApplicationApi();
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
                // Get a count of interactions grouped by interface type (e.g. screen, audio, chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetInteractionsAggregatedByInterfaceType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetInteractionsAggregatedByInterfaceType: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionsaggregatedbylocale"></a>
# **GetInteractionsAggregatedByLocale**
> List<LocaleUsageModel> GetInteractionsAggregatedByLocale (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of interactions grouped by locale

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

            var apiInstance = new ApplicationApi();
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
                // Get a count of interactions grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetInteractionsAggregatedByLocale(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetInteractionsAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionshistogram"></a>
# **GetInteractionsHistogram**
> List<DatedUsageModel> GetInteractionsHistogram (string applicationId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a histogram of interactions (raw requests)

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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
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
                // Get a histogram of interactions (raw requests)
                List&lt;DatedUsageModel&gt; result = apiInstance.GetInteractionsHistogram(applicationId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetInteractionsHistogram: " + e.Message );
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
> List<AssistantUsageModel> GetNewUsersAggregatedByAssistant (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get new user count for application grouped by assistant

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

            var apiInstance = new ApplicationApi();
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
                // Get new user count for application grouped by assistant
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetNewUsersAggregatedByAssistant(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetNewUsersAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusersaggregatedbydevicetarget"></a>
# **GetNewUsersAggregatedByDeviceTarget**
> List<DeviceTargetUsageModel> GetNewUsersAggregatedByDeviceTarget (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get new user count for application grouped by device target

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

            var apiInstance = new ApplicationApi();
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
                // Get new user count for application grouped by device target
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetNewUsersAggregatedByDeviceTarget(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetNewUsersAggregatedByDeviceTarget: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusersaggregatedbyfeaturetype"></a>
# **GetNewUsersAggregatedByFeatureType**
> List<FeatureUsageModel> GetNewUsersAggregatedByFeatureType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get new user count for application grouped by feature type

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetNewUsersAggregatedByFeatureTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get new user count for application grouped by feature type
                List&lt;FeatureUsageModel&gt; result = apiInstance.GetNewUsersAggregatedByFeatureType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetNewUsersAggregatedByFeatureType: " + e.Message );
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

[**List<FeatureUsageModel>**](FeatureUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusersaggregatedbyinterface"></a>
# **GetNewUsersAggregatedByInterface**
> List<InterfaceUsageModel> GetNewUsersAggregatedByInterface (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get new user count for application grouped by interface (e.g. screen, audio, chat)

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

            var apiInstance = new ApplicationApi();
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
                // Get new user count for application grouped by interface (e.g. screen, audio, chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetNewUsersAggregatedByInterface(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetNewUsersAggregatedByInterface: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusersaggregatedbylocale"></a>
# **GetNewUsersAggregatedByLocale**
> List<LocaleUsageModel> GetNewUsersAggregatedByLocale (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get new user count for application grouped by locale

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

            var apiInstance = new ApplicationApi();
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
                // Get new user count for application grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetNewUsersAggregatedByLocale(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetNewUsersAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnewusershistogram"></a>
# **GetNewUsersHistogram**
> List<DatedUsageModel> GetNewUsersHistogram (string applicationId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
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
                List&lt;DatedUsageModel&gt; result = apiInstance.GetNewUsersHistogram(applicationId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetNewUsersHistogram: " + e.Message );
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
> List<AssistantUsageModel> GetSessionsAggregatedByAssistant (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of sessions grouped by assistant platform

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

            var apiInstance = new ApplicationApi();
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
                // Get a count of sessions grouped by assistant platform
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetSessionsAggregatedByAssistant(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetSessionsAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionsaggregatedbydevicetarget"></a>
# **GetSessionsAggregatedByDeviceTarget**
> List<DeviceTargetUsageModel> GetSessionsAggregatedByDeviceTarget (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of sessions grouped by device target

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

            var apiInstance = new ApplicationApi();
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
                // Get a count of sessions grouped by device target
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetSessionsAggregatedByDeviceTarget(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetSessionsAggregatedByDeviceTarget: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionsaggregatedbyfeaturetype"></a>
# **GetSessionsAggregatedByFeatureType**
> List<FeatureUsageModel> GetSessionsAggregatedByFeatureType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Gets a count of sessions grouped by feature type

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetSessionsAggregatedByFeatureTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Gets a count of sessions grouped by feature type
                List&lt;FeatureUsageModel&gt; result = apiInstance.GetSessionsAggregatedByFeatureType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetSessionsAggregatedByFeatureType: " + e.Message );
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

[**List<FeatureUsageModel>**](FeatureUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionsaggregatedbyinterfacetype"></a>
# **GetSessionsAggregatedByInterfaceType**
> List<InterfaceUsageModel> GetSessionsAggregatedByInterfaceType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of sessions grouped by interface type (e.g. screen, audio, chat)

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

            var apiInstance = new ApplicationApi();
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
                // Get a count of sessions grouped by interface type (e.g. screen, audio, chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetSessionsAggregatedByInterfaceType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetSessionsAggregatedByInterfaceType: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionsaggregatedbylocale"></a>
# **GetSessionsAggregatedByLocale**
> List<LocaleUsageModel> GetSessionsAggregatedByLocale (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get a count of sessions grouped by locale

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

            var apiInstance = new ApplicationApi();
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
                // Get a count of sessions grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetSessionsAggregatedByLocale(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetSessionsAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionshistogram"></a>
# **GetSessionsHistogram**
> List<DatedUsageModel> GetSessionsHistogram (string applicationId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
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
                List&lt;DatedUsageModel&gt; result = apiInstance.GetSessionsHistogram(applicationId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetSessionsHistogram: " + e.Message );
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
> List<AssistantUsageModel> GetUsersAggregatedByAssistant (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get application user count grouped by assistant

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

            var apiInstance = new ApplicationApi();
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
                // Get application user count grouped by assistant
                List&lt;AssistantUsageModel&gt; result = apiInstance.GetUsersAggregatedByAssistant(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetUsersAggregatedByAssistant: " + e.Message );
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

[**List<AssistantUsageModel>**](AssistantUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersaggregatedbydevicetarget"></a>
# **GetUsersAggregatedByDeviceTarget**
> List<DeviceTargetUsageModel> GetUsersAggregatedByDeviceTarget (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get application user count grouped by device target

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

            var apiInstance = new ApplicationApi();
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
                // Get application user count grouped by device target
                List&lt;DeviceTargetUsageModel&gt; result = apiInstance.GetUsersAggregatedByDeviceTarget(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetUsersAggregatedByDeviceTarget: " + e.Message );
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

[**List<DeviceTargetUsageModel>**](DeviceTargetUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersaggregatedbyfeaturetype"></a>
# **GetUsersAggregatedByFeatureType**
> List<FeatureUsageModel> GetUsersAggregatedByFeatureType (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get application user count grouped by feature type

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetUsersAggregatedByFeatureTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
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
                // Get application user count grouped by feature type
                List&lt;FeatureUsageModel&gt; result = apiInstance.GetUsersAggregatedByFeatureType(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetUsersAggregatedByFeatureType: " + e.Message );
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

[**List<FeatureUsageModel>**](FeatureUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersaggregatedbyinterface"></a>
# **GetUsersAggregatedByInterface**
> List<InterfaceUsageModel> GetUsersAggregatedByInterface (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get application user count grouped by interface (e.g. screen, audio, chat)

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

            var apiInstance = new ApplicationApi();
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
                // Get application user count grouped by interface (e.g. screen, audio, chat)
                List&lt;InterfaceUsageModel&gt; result = apiInstance.GetUsersAggregatedByInterface(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetUsersAggregatedByInterface: " + e.Message );
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

[**List<InterfaceUsageModel>**](InterfaceUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersaggregatedbylocale"></a>
# **GetUsersAggregatedByLocale**
> List<LocaleUsageModel> GetUsersAggregatedByLocale (string applicationId, DateTime? startDate, DateTime? endDate, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

Get application user count grouped by locale

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

            var apiInstance = new ApplicationApi();
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
                // Get application user count grouped by locale
                List&lt;LocaleUsageModel&gt; result = apiInstance.GetUsersAggregatedByLocale(applicationId, startDate, endDate, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetUsersAggregatedByLocale: " + e.Message );
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

[**List<LocaleUsageModel>**](LocaleUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusershistogram"></a>
# **GetUsersHistogram**
> List<DatedUsageModel> GetUsersHistogram (string applicationId, DateTime? startDate, DateTime? endDate, string interval = null, List<string> locales = null, List<string> deviceTargetIds = null, List<string> assistants = null, List<string> userIds = null, List<string> sessionIds = null)

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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
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
                List&lt;DatedUsageModel&gt; result = apiInstance.GetUsersHistogram(applicationId, startDate, endDate, interval, locales, deviceTargetIds, assistants, userIds, sessionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetUsersHistogram: " + e.Message );
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

