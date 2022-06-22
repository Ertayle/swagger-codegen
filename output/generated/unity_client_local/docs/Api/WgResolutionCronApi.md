# UnityBestHttp2Client.Api.WgResolutionCronApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**wgResolutionCronControllerCreateWgResolutionCronEntry**](WgResolutionCronApi.md#wgresolutioncroncontrollercreatewgresolutioncronentry) | **POST** /v1/wgs/{wgId}/resolution/cron/{phaseNumber} | 
[**wgResolutionCronControllerDeleteWgResolutionCronEntry**](WgResolutionCronApi.md#wgresolutioncroncontrollerdeletewgresolutioncronentry) | **DELETE** /v1/wgs/{wgId}/resolution/cron | 
[**wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDate**](WgResolutionCronApi.md#wgresolutioncroncontrollerfindallcronentriesbeforecurrentdate) | **GET** /v1/wgs/{wgId}/resolution/cron | 

<a name="wgresolutioncroncontrollercreatewgresolutioncronentry"></a>
# **wgResolutionCronControllerCreateWgResolutionCronEntry**
> WgResolutionCronEntity wgResolutionCronControllerCreateWgResolutionCronEntry (String wgId, BigDecimal phaseNumber)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgResolutionCronControllerCreateWgResolutionCronEntryExample
    {
        public void main()
        {
            var apiInstance = new WgResolutionCronApi();
            var wgId = wgId_example;  // String | Id of the Wargame
            var phaseNumber = 1.2;  // BigDecimal | 

            try
            {
                WgResolutionCronEntity result = apiInstance.wgResolutionCronControllerCreateWgResolutionCronEntry(wgId, phaseNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgResolutionCronApi.wgResolutionCronControllerCreateWgResolutionCronEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 
 **phaseNumber** | **BigDecimal**|  | 

### Return type

[**WgResolutionCronEntity**](WgResolutionCronEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgresolutioncroncontrollerdeletewgresolutioncronentry"></a>
# **wgResolutionCronControllerDeleteWgResolutionCronEntry**
> void wgResolutionCronControllerDeleteWgResolutionCronEntry (String wgId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgResolutionCronControllerDeleteWgResolutionCronEntryExample
    {
        public void main()
        {
            var apiInstance = new WgResolutionCronApi();
            var wgId = wgId_example;  // String | Id of the Wargame

            try
            {
                apiInstance.wgResolutionCronControllerDeleteWgResolutionCronEntry(wgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgResolutionCronApi.wgResolutionCronControllerDeleteWgResolutionCronEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgresolutioncroncontrollerfindallcronentriesbeforecurrentdate"></a>
# **wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDate**
> List wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDate (String wgId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDateExample
    {
        public void main()
        {
            var apiInstance = new WgResolutionCronApi();
            var wgId = wgId_example;  // String | Id of the Wargame

            try
            {
                List result = apiInstance.wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDate(wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgResolutionCronApi.wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 

### Return type

[**List**](WgResolutionCronEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

