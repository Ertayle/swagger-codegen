# UnityBestHttp2Client.Api.WgActionsApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionControllerDeleteAllByWgId**](WgActionsApi.md#actioncontrollerdeleteallbywgid) | **DELETE** /v1/wgs/{wgId}/actions | 
[**actionControllerDeleteAllByWgIdAndPhase**](WgActionsApi.md#actioncontrollerdeleteallbywgidandphase) | **DELETE** /v1/wgs/{wgId}/actions/phase/{phase} | 
[**actionControllerDeleteByTerritory**](WgActionsApi.md#actioncontrollerdeletebyterritory) | **DELETE** /v1/wgs/{wgId}/actions/phase/{phase}/{territory} | 
[**actionControllerFindAll**](WgActionsApi.md#actioncontrollerfindall) | **GET** /v1/wgs/{wgId}/actions | 
[**actionControllerFindAllInPhase**](WgActionsApi.md#actioncontrollerfindallinphase) | **GET** /v1/wgs/{wgId}/actions/phase/{phase} | 
[**actionControllerFindOne**](WgActionsApi.md#actioncontrollerfindone) | **GET** /v1/wgs/{wgId}/actions/phase/{phase}/{territory} | 
[**actionControllerPostAction**](WgActionsApi.md#actioncontrollerpostaction) | **POST** /v1/wgs/{wgId}/actions/phase/{phase}/{territory} | 

<a name="actioncontrollerdeleteallbywgid"></a>
# **actionControllerDeleteAllByWgId**
> void actionControllerDeleteAllByWgId (String wgId)



Delete all actions in a Wg

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class actionControllerDeleteAllByWgIdExample
    {
        public void main()
        {

            var apiInstance = new WgActionsApi();
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                apiInstance.actionControllerDeleteAllByWgId(wgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgActionsApi.actionControllerDeleteAllByWgId: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| ID of the Wargame | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actioncontrollerdeleteallbywgidandphase"></a>
# **actionControllerDeleteAllByWgIdAndPhase**
> void actionControllerDeleteAllByWgIdAndPhase (String wgId, Integer phase)



Delete all actions in a Wg phase

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class actionControllerDeleteAllByWgIdAndPhaseExample
    {
        public void main()
        {

            var apiInstance = new WgActionsApi();
            var wgId = wgId_example;  // String | ID of the Wargame
            var phase = 56;  // Integer | Phase of the actions to delete

            try
            {
                apiInstance.actionControllerDeleteAllByWgIdAndPhase(wgId, phase);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgActionsApi.actionControllerDeleteAllByWgIdAndPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| ID of the Wargame | 
 **phase** | **Integer**| Phase of the actions to delete | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actioncontrollerdeletebyterritory"></a>
# **actionControllerDeleteByTerritory**
> void actionControllerDeleteByTerritory (String wgId, Integer phase, String territory)



Delete a specific territory action

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class actionControllerDeleteByTerritoryExample
    {
        public void main()
        {

            var apiInstance = new WgActionsApi();
            var wgId = wgId_example;  // String | ID of the Wargame associated with the actions to delete
            var phase = 56;  // Integer | Current phase number
            var territory = territory_example;  // String | the territory label

            try
            {
                apiInstance.actionControllerDeleteByTerritory(wgId, phase, territory);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgActionsApi.actionControllerDeleteByTerritory: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| ID of the Wargame associated with the actions to delete | 
 **phase** | **Integer**| Current phase number | 
 **territory** | **String**| the territory label | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actioncontrollerfindall"></a>
# **actionControllerFindAll**
> List actionControllerFindAll (String wgId)



Find all Actions in a Wargame

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class actionControllerFindAllExample
    {
        public void main()
        {

            var apiInstance = new WgActionsApi();
            var wgId = wgId_example;  // String | ID of the Wargame to query for actions

            try
            {
                List result = apiInstance.actionControllerFindAll(wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgActionsApi.actionControllerFindAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| ID of the Wargame to query for actions | 

### Return type

[**List**](WgActionEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actioncontrollerfindallinphase"></a>
# **actionControllerFindAllInPhase**
> List actionControllerFindAllInPhase (Integer phase, String wgId)



Find Actions in a Wargame at given Phase

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class actionControllerFindAllInPhaseExample
    {
        public void main()
        {

            var apiInstance = new WgActionsApi();
            var phase = 56;  // Integer | Current phase
            var wgId = wgId_example;  // String | ID of the Wargame to query for actions

            try
            {
                List result = apiInstance.actionControllerFindAllInPhase(phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgActionsApi.actionControllerFindAllInPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **phase** | **Integer**| Current phase | 
 **wgId** | **String**| ID of the Wargame to query for actions | 

### Return type

[**List**](WgActionEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actioncontrollerfindone"></a>
# **actionControllerFindOne**
> List actionControllerFindOne (String wgId, Integer phase, String territory)



Find Actions in a Wargame at given Phase filtered by territory label

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class actionControllerFindOneExample
    {
        public void main()
        {

            var apiInstance = new WgActionsApi();
            var wgId = wgId_example;  // String | ID of the Wargame to query for actions
            var phase = 56;  // Integer | Indicate current phase to filter already resolved actions
            var territory = territory_example;  // String | the territory label

            try
            {
                List result = apiInstance.actionControllerFindOne(wgId, phase, territory);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgActionsApi.actionControllerFindOne: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| ID of the Wargame to query for actions | 
 **phase** | **Integer**| Indicate current phase to filter already resolved actions | 
 **territory** | **String**| the territory label | 

### Return type

[**List**](WgActionEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actioncontrollerpostaction"></a>
# **actionControllerPostAction**
> WgStateEntity actionControllerPostAction (WgActionEntity body, Integer phase, String territory, String wgId)



Create a new Action

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class actionControllerPostActionExample
    {
        public void main()
        {

            var apiInstance = new WgActionsApi();
            var body = new WgActionEntity(); // WgActionEntity | 
            var phase = 56;  // Integer | Current phase
            var territory = territory_example;  // String | Territory label
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.actionControllerPostAction(body, phase, territory, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgActionsApi.actionControllerPostAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**WgActionEntity**](WgActionEntity.md)|  | 
 **phase** | **Integer**| Current phase | 
 **territory** | **String**| Territory label | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

