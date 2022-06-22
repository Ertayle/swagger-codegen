# UnityBestHttp2Client.Api.WargamesApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**wgControllerCreateWargame**](WargamesApi.md#wgcontrollercreatewargame) | **POST** /v1/wgs | 
[**wgControllerDeleteWargame**](WargamesApi.md#wgcontrollerdeletewargame) | **DELETE** /v1/wgs/{wgId} | 
[**wgControllerEditWargame**](WargamesApi.md#wgcontrollereditwargame) | **POST** /v1/wgs/{wgId} | 
[**wgControllerGetAllWargame**](WargamesApi.md#wgcontrollergetallwargame) | **GET** /v1/wgs | 
[**wgControllerGetWargame**](WargamesApi.md#wgcontrollergetwargame) | **GET** /v1/wgs/{wgId} | 
[**wgControllerResetWargame**](WargamesApi.md#wgcontrollerresetwargame) | **POST** /v1/wgs/reset/{wgId} | 

<a name="wgcontrollercreatewargame"></a>
# **wgControllerCreateWargame**
> WgEntity wgControllerCreateWargame (WgEntity body)



Create a new Wargame instance

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgControllerCreateWargameExample
    {
        public void main()
        {

            var apiInstance = new WargamesApi();
            var body = new WgEntity(); // WgEntity | 

            try
            {
                WgEntity result = apiInstance.wgControllerCreateWargame(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WargamesApi.wgControllerCreateWargame: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**WgEntity**](WgEntity.md)|  | 

### Return type

[**WgEntity**](WgEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgcontrollerdeletewargame"></a>
# **wgControllerDeleteWargame**
> void wgControllerDeleteWargame (String wgId)



Delete all data regarding a Wargame instance

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgControllerDeleteWargameExample
    {
        public void main()
        {

            var apiInstance = new WargamesApi();
            var wgId = wgId_example;  // String | Id of the Wargame

            try
            {
                apiInstance.wgControllerDeleteWargame(wgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WargamesApi.wgControllerDeleteWargame: " + e.Message );
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

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgcontrollereditwargame"></a>
# **wgControllerEditWargame**
> WgEntity wgControllerEditWargame (WgEntity body, String wgId)



Edit a specific Wargame instance

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgControllerEditWargameExample
    {
        public void main()
        {

            var apiInstance = new WargamesApi();
            var body = new WgEntity(); // WgEntity | 
            var wgId = wgId_example;  // String | Id of the Wargame

            try
            {
                WgEntity result = apiInstance.wgControllerEditWargame(body, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WargamesApi.wgControllerEditWargame: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**WgEntity**](WgEntity.md)|  | 
 **wgId** | **String**| Id of the Wargame | 

### Return type

[**WgEntity**](WgEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgcontrollergetallwargame"></a>
# **wgControllerGetAllWargame**
> List wgControllerGetAllWargame ()



Get all wargames instances

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgControllerGetAllWargameExample
    {
        public void main()
        {

            var apiInstance = new WargamesApi();

            try
            {
                List result = apiInstance.wgControllerGetAllWargame();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WargamesApi.wgControllerGetAllWargame: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List**](WgEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgcontrollergetwargame"></a>
# **wgControllerGetWargame**
> WgEntity wgControllerGetWargame (String wgId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgControllerGetWargameExample
    {
        public void main()
        {

            var apiInstance = new WargamesApi();
            var wgId = wgId_example;  // String | Id of the Wargame

            try
            {
                WgEntity result = apiInstance.wgControllerGetWargame(wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WargamesApi.wgControllerGetWargame: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 

### Return type

[**WgEntity**](WgEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgcontrollerresetwargame"></a>
# **wgControllerResetWargame**
> WgEntity wgControllerResetWargame (String wgId)



Reset a specific Wargame instance

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgControllerResetWargameExample
    {
        public void main()
        {

            var apiInstance = new WargamesApi();
            var wgId = wgId_example;  // String | Id of the Wargame

            try
            {
                WgEntity result = apiInstance.wgControllerResetWargame(wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WargamesApi.wgControllerResetWargame: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 

### Return type

[**WgEntity**](WgEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

