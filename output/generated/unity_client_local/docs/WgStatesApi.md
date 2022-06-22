# UnityBestHttp2Client.Api.WgStatesApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**stateControllerDeleteState**](WgStatesApi.md#statecontrollerdeletestate) | **DELETE** /v1/wgs/{wgId}/states/phase/{phase} | 
[**stateControllerGetState**](WgStatesApi.md#statecontrollergetstate) | **GET** /v1/wgs/{wgId}/states/phase/{phase} | 
[**stateControllerGetStateFiltered**](WgStatesApi.md#statecontrollergetstatefiltered) | **GET** /v1/wgs/{wgId}/states/phase/{phase}/filtered | 
[**stateControllerGetStatesByWgId**](WgStatesApi.md#statecontrollergetstatesbywgid) | **GET** /v1/wgs/{wgId}/states | 
[**stateControllerSetWargameState**](WgStatesApi.md#statecontrollersetwargamestate) | **POST** /v1/wgs/{wgId}/states | 

<a name="statecontrollerdeletestate"></a>
# **stateControllerDeleteState**
> void stateControllerDeleteState (String wgId, Integer phase)



Delete a specific Wargame state with the Wargame ID and current phase

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class stateControllerDeleteStateExample
    {
        public void main()
        {

            var apiInstance = new WgStatesApi();
            var wgId = wgId_example;  // String | Id of the Wargame
            var phase = 56;  // Integer | Phase number to look for

            try
            {
                apiInstance.stateControllerDeleteState(wgId, phase);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgStatesApi.stateControllerDeleteState: " + e.Message );
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

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statecontrollergetstate"></a>
# **stateControllerGetState**
> WgStateEntity stateControllerGetState (String wgId, Integer phase)



Get a specific Wargame state with the Wargame ID and current phase

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class stateControllerGetStateExample
    {
        public void main()
        {

            var apiInstance = new WgStatesApi();
            var wgId = wgId_example;  // String | Id of the Wargame
            var phase = 56;  // Integer | Phase number to look for

            try
            {
                WgStateEntity result = apiInstance.stateControllerGetState(wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgStatesApi.stateControllerGetState: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 
 **phase** | **Integer**| Phase number to look for | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statecontrollergetstatefiltered"></a>
# **stateControllerGetStateFiltered**
> WgStateEntity stateControllerGetStateFiltered (String wgId, Integer phase)



Get a specific Wargame state with the Wargame ID and current phase

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class stateControllerGetStateFilteredExample
    {
        public void main()
        {

            var apiInstance = new WgStatesApi();
            var wgId = wgId_example;  // String | Id of the Wargame
            var phase = 56;  // Integer | Phase number to look for

            try
            {
                WgStateEntity result = apiInstance.stateControllerGetStateFiltered(wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgStatesApi.stateControllerGetStateFiltered: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 
 **phase** | **Integer**| Phase number to look for | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statecontrollergetstatesbywgid"></a>
# **stateControllerGetStatesByWgId**
> WgStateEntity stateControllerGetStatesByWgId (String wgId)



Get all Wargame states with a Wargame ID

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class stateControllerGetStatesByWgIdExample
    {
        public void main()
        {

            var apiInstance = new WgStatesApi();
            var wgId = wgId_example;  // String | Id of the Wargame

            try
            {
                WgStateEntity result = apiInstance.stateControllerGetStatesByWgId(wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgStatesApi.stateControllerGetStatesByWgId: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Id of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statecontrollersetwargamestate"></a>
# **stateControllerSetWargameState**
> WgStateEntity stateControllerSetWargameState (WgStateEntity body, String wgId)



Create or update a Wargame state

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class stateControllerSetWargameStateExample
    {
        public void main()
        {

            var apiInstance = new WgStatesApi();
            var body = new WgStateEntity(); // WgStateEntity | 
            var wgId = wgId_example;  // String | Id of the Wargame

            try
            {
                WgStateEntity result = apiInstance.stateControllerSetWargameState(body, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgStatesApi.stateControllerSetWargameState: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**WgStateEntity**](WgStateEntity.md)|  | 
 **wgId** | **String**| Id of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

