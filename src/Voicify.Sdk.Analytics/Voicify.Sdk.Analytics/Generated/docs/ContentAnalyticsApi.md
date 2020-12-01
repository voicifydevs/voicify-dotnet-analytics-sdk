# Voicify.Sdk.Analytics.Api.ContentAnalyticsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApplicationHistogram**](ContentAnalyticsApi.md#getapplicationhistogram) | **GET** /api/ContentAnalytics/requests/histogram/{applicationId}/{contentId} | Gets the request data histogram for the given content item
[**GetApplicationSessions**](ContentAnalyticsApi.md#getapplicationsessions) | **GET** /api/ContentAnalytics/sessions/usage/{applicationId}/{contentId} | Gets the session request data for the given content item
[**GetApplicationSessionssHistogram**](ContentAnalyticsApi.md#getapplicationsessionsshistogram) | **GET** /api/ContentAnalytics/sessions/histogram/{applicationId}/{contentId} | Gets the session data histogram for the given content item
[**GetApplicationUsage**](ContentAnalyticsApi.md#getapplicationusage) | **GET** /api/ContentAnalytics/requests/usage/{applicationId}/{contentId} | Gets the request data for the given content item
[**GetApplicationUsers**](ContentAnalyticsApi.md#getapplicationusers) | **GET** /api/ContentAnalytics/users/usage/{applicationId}/{contentId} | Gets the user request data for the given content item
[**GetApplicationUsersHistogram**](ContentAnalyticsApi.md#getapplicationusershistogram) | **GET** /api/ContentAnalytics/users/histogram/{applicationId}/{contentId} | Gets the users data histogram for the given content item
[**GetBasicApplicationStats**](ContentAnalyticsApi.md#getbasicapplicationstats) | **GET** /api/ContentAnalytics/stats/{applicationId}/{contentId} | Gets the basic stats for the given piece of content


<a name="getapplicationhistogram"></a>
# **GetApplicationHistogram**
> List<DatedUsageModel> GetApplicationHistogram (string applicationId, string contentId, string interval = null, DateTime? startDate = null, DateTime? endDate = null)

Gets the request data histogram for the given content item

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var interval = interval_example;  // string |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the request data histogram for the given content item
                List&lt;DatedUsageModel&gt; result = apiInstance.GetApplicationHistogram(applicationId, contentId, interval, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentAnalyticsApi.GetApplicationHistogram: " + e.Message );
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
 **interval** | **string**|  | [optional] 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**List<DatedUsageModel>**](DatedUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationsessions"></a>
# **GetApplicationSessions**
> ContentUsageModel GetApplicationSessions (string applicationId, string contentId, DateTime? startDate = null, DateTime? endDate = null)

Gets the session request data for the given content item

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationSessionsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the session request data for the given content item
                ContentUsageModel result = apiInstance.GetApplicationSessions(applicationId, contentId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentAnalyticsApi.GetApplicationSessions: " + e.Message );
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
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ContentUsageModel**](ContentUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationsessionsshistogram"></a>
# **GetApplicationSessionssHistogram**
> List<DatedUsageModel> GetApplicationSessionssHistogram (string applicationId, string contentId, string interval = null, DateTime? startDate = null, DateTime? endDate = null)

Gets the session data histogram for the given content item

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationSessionssHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var interval = interval_example;  // string |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the session data histogram for the given content item
                List&lt;DatedUsageModel&gt; result = apiInstance.GetApplicationSessionssHistogram(applicationId, contentId, interval, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentAnalyticsApi.GetApplicationSessionssHistogram: " + e.Message );
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
 **interval** | **string**|  | [optional] 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**List<DatedUsageModel>**](DatedUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationusage"></a>
# **GetApplicationUsage**
> ContentUsageModel GetApplicationUsage (string applicationId, string contentId, DateTime? startDate = null, DateTime? endDate = null)

Gets the request data for the given content item

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationUsageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the request data for the given content item
                ContentUsageModel result = apiInstance.GetApplicationUsage(applicationId, contentId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentAnalyticsApi.GetApplicationUsage: " + e.Message );
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
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ContentUsageModel**](ContentUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationusers"></a>
# **GetApplicationUsers**
> ContentUsageModel GetApplicationUsers (string applicationId, string contentId, DateTime? startDate = null, DateTime? endDate = null)

Gets the user request data for the given content item

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationUsersExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the user request data for the given content item
                ContentUsageModel result = apiInstance.GetApplicationUsers(applicationId, contentId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentAnalyticsApi.GetApplicationUsers: " + e.Message );
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
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ContentUsageModel**](ContentUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationusershistogram"></a>
# **GetApplicationUsersHistogram**
> List<DatedUsageModel> GetApplicationUsersHistogram (string applicationId, string contentId, string interval = null, DateTime? startDate = null, DateTime? endDate = null)

Gets the users data histogram for the given content item

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationUsersHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var interval = interval_example;  // string |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the users data histogram for the given content item
                List&lt;DatedUsageModel&gt; result = apiInstance.GetApplicationUsersHistogram(applicationId, contentId, interval, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentAnalyticsApi.GetApplicationUsersHistogram: " + e.Message );
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
 **interval** | **string**|  | [optional] 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**List<DatedUsageModel>**](DatedUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbasicapplicationstats"></a>
# **GetBasicApplicationStats**
> ApplicationStatisticsModel GetBasicApplicationStats (string applicationId, string contentId, DateTime? startDate = null, DateTime? endDate = null)

Gets the basic stats for the given piece of content

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetBasicApplicationStatsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContentAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var contentId = contentId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the basic stats for the given piece of content
                ApplicationStatisticsModel result = apiInstance.GetBasicApplicationStats(applicationId, contentId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentAnalyticsApi.GetBasicApplicationStats: " + e.Message );
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
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ApplicationStatisticsModel**](ApplicationStatisticsModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

