# UnityBestHttp2Client.Api.WgParametersApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**parametersControllerGetInfraCost**](WgParametersApi.md#parameterscontrollergetinfracost) | **POST** /v1/parameters/cost/{infraType} | 
[**parametersControllerGetWgParameters**](WgParametersApi.md#parameterscontrollergetwgparameters) | **GET** /v1/parameters/{wgId} | 

<a name="parameterscontrollergetinfracost"></a>
# **parametersControllerGetInfraCost**
> WgPriceModel parametersControllerGetInfraCost (WgParameters body, String infraType)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class parametersControllerGetInfraCostExample
    {
        public void main()
        {
            var apiInstance = new WgParametersApi();
            var body = new WgParameters(); // WgParameters | 
            var infraType = infraType_example;  // String | InfraType

            try
            {
                WgPriceModel result = apiInstance.parametersControllerGetInfraCost(body, infraType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgParametersApi.parametersControllerGetInfraCost: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**WgParameters**](WgParameters.md)|  | 
 **infraType** | **String**| InfraType | 

### Return type

[**WgPriceModel**](WgPriceModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parameterscontrollergetwgparameters"></a>
# **parametersControllerGetWgParameters**
> WgParameters parametersControllerGetWgParameters (String wgId)



Get Wargame Parameters

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class parametersControllerGetWgParametersExample
    {
        public void main()
        {
            var apiInstance = new WgParametersApi();
            var wgId = wgId_example;  // String | Id of the Wargame

            try
            {
                WgParameters result = apiInstance.parametersControllerGetWgParameters(wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgParametersApi.parametersControllerGetWgParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 

### Return type

[**WgParameters**](WgParameters.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

