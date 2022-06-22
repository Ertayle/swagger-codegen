# UnityBestHttp2Client.Api.WgResolutionApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**wgResolutionControllerPatchPhase**](WgResolutionApi.md#wgresolutioncontrollerpatchphase) | **PATCH** /v1/wgs/{wgId}/resolution/phase/{phase}/run | 
[**wgResolutionControllerRunPhase**](WgResolutionApi.md#wgresolutioncontrollerrunphase) | **POST** /v1/wgs/{wgId}/resolution/phase/{phase}/run | 

<a name="wgresolutioncontrollerpatchphase"></a>
# **wgResolutionControllerPatchPhase**
> void wgResolutionControllerPatchPhase (String wgId, Integer phase)



Update next Phase wargame state if it exists. The method will regenerate phase N+1

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgResolutionControllerPatchPhaseExample
    {
        public void main()
        {
            var apiInstance = new WgResolutionApi();
            var wgId = wgId_example;  // String | Id of the Wargame
            var phase = 56;  // Integer | Phase number to look for

            try
            {
                apiInstance.wgResolutionControllerPatchPhase(wgId, phase);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgResolutionApi.wgResolutionControllerPatchPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 
 **phase** | **Integer**| Phase number to look for | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgresolutioncontrollerrunphase"></a>
# **wgResolutionControllerRunPhase**
> WgStateEntity wgResolutionControllerRunPhase (String wgId, Integer phase)



Create next Phase wargame state. The method will generate phase N+1

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgResolutionControllerRunPhaseExample
    {
        public void main()
        {
            var apiInstance = new WgResolutionApi();
            var wgId = wgId_example;  // String | Id of the Wargame
            var phase = 56;  // Integer | Phase number to execute, will generate phase N+1

            try
            {
                WgStateEntity result = apiInstance.wgResolutionControllerRunPhase(wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgResolutionApi.wgResolutionControllerRunPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 
 **phase** | **Integer**| Phase number to execute, will generate phase N+1 | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

