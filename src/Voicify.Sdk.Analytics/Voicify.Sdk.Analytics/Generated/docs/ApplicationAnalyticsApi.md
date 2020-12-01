# Voicify.Sdk.Analytics.Api.ApplicationAnalyticsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApplicationContentMisses**](ApplicationAnalyticsApi.md#getapplicationcontentmisses) | **GET** /api/ApplicationAnalytics/contentmisses/usage/{applicationId} | Gets the content miss data for an app
[**GetApplicationContentMissesHistogram**](ApplicationAnalyticsApi.md#getapplicationcontentmisseshistogram) | **GET** /api/ApplicationAnalytics/contentmisses/histogram/{applicationId} | Gets the content miss histogram data for an app
[**GetApplicationFeatureMisses**](ApplicationAnalyticsApi.md#getapplicationfeaturemisses) | **GET** /api/ApplicationAnalytics/featuremisses/usage/{applicationId} | Gets the feature miss data for an app
[**GetApplicationFeatureMissesHistogram**](ApplicationAnalyticsApi.md#getapplicationfeaturemisseshistogram) | **GET** /api/ApplicationAnalytics/featuremisses/histogram/{applicationId} | Gets the feature miss histogram data for an app
[**GetApplicationHistogram**](ApplicationAnalyticsApi.md#getapplicationhistogram) | **GET** /api/ApplicationAnalytics/requests/histogram/{applicationId} | Gets the request data histogram for an app
[**GetApplicationMissStats**](ApplicationAnalyticsApi.md#getapplicationmissstats) | **GET** /api/ApplicationAnalytics/missstats/{applicationId} | Gets the basic miss/failure stats for an app
[**GetApplicationSessions**](ApplicationAnalyticsApi.md#getapplicationsessions) | **GET** /api/ApplicationAnalytics/sessions/usage/{applicationId} | Gets the session usage data for an app
[**GetApplicationSessionsHistogram**](ApplicationAnalyticsApi.md#getapplicationsessionshistogram) | **GET** /api/ApplicationAnalytics/sessions/histogram/{applicationId} | Gets the session data histogram for an app
[**GetApplicationTopHits**](ApplicationAnalyticsApi.md#getapplicationtophits) | **GET** /api/ApplicationAnalytics/tophits/{applicationId} | Gets the top hit content for an app
[**GetApplicationTopMisses**](ApplicationAnalyticsApi.md#getapplicationtopmisses) | **GET** /api/ApplicationAnalytics/topmisses/{applicationId} | Gets the top missed interactions for an app
[**GetApplicationUsage**](ApplicationAnalyticsApi.md#getapplicationusage) | **GET** /api/ApplicationAnalytics/requests/usage/{applicationId} | Gets the request usage data for an app
[**GetApplicationUsers**](ApplicationAnalyticsApi.md#getapplicationusers) | **GET** /api/ApplicationAnalytics/users/usage/{applicationId} | Gets the user usage data for an app
[**GetApplicationUsersHistogram**](ApplicationAnalyticsApi.md#getapplicationusershistogram) | **GET** /api/ApplicationAnalytics/users/histogram/{applicationId} | Gets the users data histogram for an app
[**GetBasicApplicationStats**](ApplicationAnalyticsApi.md#getbasicapplicationstats) | **GET** /api/ApplicationAnalytics/stats/{applicationId} | Gets the basic statistics for an app


<a name="getapplicationcontentmisses"></a>
# **GetApplicationContentMisses**
> ApplicationUsageModel GetApplicationContentMisses (string applicationId, DateTime? startDate = null, DateTime? endDate = null)

Gets the content miss data for an app

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationContentMissesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the content miss data for an app
                ApplicationUsageModel result = apiInstance.GetApplicationContentMisses(applicationId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationContentMisses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ApplicationUsageModel**](ApplicationUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationcontentmisseshistogram"></a>
# **GetApplicationContentMissesHistogram**
> List<DatedUsageModel> GetApplicationContentMissesHistogram (string applicationId, string interval = null, DateTime? startDate = null, DateTime? endDate = null)

Gets the content miss histogram data for an app

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationContentMissesHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var interval = interval_example;  // string |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the content miss histogram data for an app
                List&lt;DatedUsageModel&gt; result = apiInstance.GetApplicationContentMissesHistogram(applicationId, interval, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationContentMissesHistogram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
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

<a name="getapplicationfeaturemisses"></a>
# **GetApplicationFeatureMisses**
> ApplicationUsageModel GetApplicationFeatureMisses (string applicationId, DateTime? startDate = null, DateTime? endDate = null)

Gets the feature miss data for an app

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationFeatureMissesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the feature miss data for an app
                ApplicationUsageModel result = apiInstance.GetApplicationFeatureMisses(applicationId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationFeatureMisses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ApplicationUsageModel**](ApplicationUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationfeaturemisseshistogram"></a>
# **GetApplicationFeatureMissesHistogram**
> List<DatedUsageModel> GetApplicationFeatureMissesHistogram (string applicationId, string interval = null, DateTime? startDate = null, DateTime? endDate = null)

Gets the feature miss histogram data for an app

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationFeatureMissesHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var interval = interval_example;  // string |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the feature miss histogram data for an app
                List&lt;DatedUsageModel&gt; result = apiInstance.GetApplicationFeatureMissesHistogram(applicationId, interval, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationFeatureMissesHistogram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
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

<a name="getapplicationhistogram"></a>
# **GetApplicationHistogram**
> List<DatedUsageModel> GetApplicationHistogram (string applicationId, string interval = null, DateTime? startDate = null, DateTime? endDate = null)

Gets the request data histogram for an app

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

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var interval = interval_example;  // string |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the request data histogram for an app
                List&lt;DatedUsageModel&gt; result = apiInstance.GetApplicationHistogram(applicationId, interval, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationHistogram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
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

<a name="getapplicationmissstats"></a>
# **GetApplicationMissStats**
> ApplicationMissStatisticsModel GetApplicationMissStats (string applicationId, DateTime? startDate = null, DateTime? endDate = null)

Gets the basic miss/failure stats for an app

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationMissStatsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the basic miss/failure stats for an app
                ApplicationMissStatisticsModel result = apiInstance.GetApplicationMissStats(applicationId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationMissStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ApplicationMissStatisticsModel**](ApplicationMissStatisticsModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationsessions"></a>
# **GetApplicationSessions**
> ApplicationUsageModel GetApplicationSessions (string applicationId, DateTime? startDate = null, DateTime? endDate = null)

Gets the session usage data for an app

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

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the session usage data for an app
                ApplicationUsageModel result = apiInstance.GetApplicationSessions(applicationId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ApplicationUsageModel**](ApplicationUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationsessionshistogram"></a>
# **GetApplicationSessionsHistogram**
> List<DatedUsageModel> GetApplicationSessionsHistogram (string applicationId, string interval = null, DateTime? startDate = null, DateTime? endDate = null)

Gets the session data histogram for an app

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Analytics.Api;
using Voicify.Sdk.Analytics.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationSessionsHistogramExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var interval = interval_example;  // string |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the session data histogram for an app
                List&lt;DatedUsageModel&gt; result = apiInstance.GetApplicationSessionsHistogram(applicationId, interval, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationSessionsHistogram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
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

<a name="getapplicationtophits"></a>
# **GetApplicationTopHits**
> TopContentHitModel GetApplicationTopHits (string applicationId, DateTime? startDate = null, DateTime? endDate = null)

Gets the top hit content for an app

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

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the top hit content for an app
                TopContentHitModel result = apiInstance.GetApplicationTopHits(applicationId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationTopHits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

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
> TopContentMissModel GetApplicationTopMisses (string applicationId, DateTime? startDate = null, DateTime? endDate = null)

Gets the top missed interactions for an app

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

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the top missed interactions for an app
                TopContentMissModel result = apiInstance.GetApplicationTopMisses(applicationId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationTopMisses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**TopContentMissModel**](TopContentMissModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationusage"></a>
# **GetApplicationUsage**
> ApplicationUsageModel GetApplicationUsage (string applicationId, DateTime? startDate = null, DateTime? endDate = null)

Gets the request usage data for an app

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

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the request usage data for an app
                ApplicationUsageModel result = apiInstance.GetApplicationUsage(applicationId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationUsage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ApplicationUsageModel**](ApplicationUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationusers"></a>
# **GetApplicationUsers**
> ApplicationUsageModel GetApplicationUsers (string applicationId, DateTime? startDate = null, DateTime? endDate = null)

Gets the user usage data for an app

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

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the user usage data for an app
                ApplicationUsageModel result = apiInstance.GetApplicationUsers(applicationId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

### Return type

[**ApplicationUsageModel**](ApplicationUsageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationusershistogram"></a>
# **GetApplicationUsersHistogram**
> List<DatedUsageModel> GetApplicationUsersHistogram (string applicationId, string interval = null, DateTime? startDate = null, DateTime? endDate = null)

Gets the users data histogram for an app

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

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var interval = interval_example;  // string |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the users data histogram for an app
                List&lt;DatedUsageModel&gt; result = apiInstance.GetApplicationUsersHistogram(applicationId, interval, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetApplicationUsersHistogram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
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
> ApplicationStatisticsModel GetBasicApplicationStats (string applicationId, DateTime? startDate = null, DateTime? endDate = null)

Gets the basic statistics for an app

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

            var apiInstance = new ApplicationAnalyticsApi();
            var applicationId = applicationId_example;  // string | 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Gets the basic statistics for an app
                ApplicationStatisticsModel result = apiInstance.GetBasicApplicationStats(applicationId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationAnalyticsApi.GetBasicApplicationStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
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

