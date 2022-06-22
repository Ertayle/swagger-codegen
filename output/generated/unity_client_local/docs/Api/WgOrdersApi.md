# UnityBestHttp2Client.Api.WgOrdersApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**orderControllerDeleteAllByWgId**](WgOrdersApi.md#ordercontrollerdeleteallbywgid) | **DELETE** /v1/wgs/{wgId}/orders | 
[**orderControllerDeleteAllByWgIdAndPhase**](WgOrdersApi.md#ordercontrollerdeleteallbywgidandphase) | **DELETE** /v1/wgs/{wgId}/orders/phase/{phase} | 
[**orderControllerDeleteOne**](WgOrdersApi.md#ordercontrollerdeleteone) | **DELETE** /v1/wgs/{wgId}/orders/phase/{phase}/{orderId} | 
[**orderControllerFindAll**](WgOrdersApi.md#ordercontrollerfindall) | **GET** /v1/wgs/{wgId}/orders | 
[**orderControllerFindAllAtPhase**](WgOrdersApi.md#ordercontrollerfindallatphase) | **GET** /v1/wgs/{wgId}/orders/phase/{phase} | 
[**orderControllerFindByAuth**](WgOrdersApi.md#ordercontrollerfindbyauth) | **GET** /v1/wgs/{wgId}/orders/byAuth | 
[**orderControllerFindByAuthAtPhase**](WgOrdersApi.md#ordercontrollerfindbyauthatphase) | **GET** /v1/wgs/{wgId}/orders/phase/{phase}/byAuth | 
[**orderControllerFindDoneByAuthBeforePhase**](WgOrdersApi.md#ordercontrollerfinddonebyauthbeforephase) | **GET** /v1/wgs/{wgId}/orders/phase/{phase}/byAuth/done | 
[**orderControllerFindOne**](WgOrdersApi.md#ordercontrollerfindone) | **GET** /v1/wgs/{wgId}/orders/phase/{phase}/{orderId} | 
[**orderControllerFindOngoing**](WgOrdersApi.md#ordercontrollerfindongoing) | **GET** /v1/wgs/{wgId}/orders/phase/{phase}/ongoing | 
[**orderControllerPatchOne**](WgOrdersApi.md#ordercontrollerpatchone) | **PATCH** /v1/wgs/{wgId}/orders/phase/{phase}/{orderId} | 
[**orderControllerPostAerialProtectionOrder**](WgOrdersApi.md#ordercontrollerpostaerialprotectionorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/aerialprotection | 
[**orderControllerPostAttackOrder**](WgOrdersApi.md#ordercontrollerpostattackorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/attack | 
[**orderControllerPostBombOrder**](WgOrdersApi.md#ordercontrollerpostbomborder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/bomb | 
[**orderControllerPostBuildConsOrder**](WgOrdersApi.md#ordercontrollerpostbuildconsorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/buildCons | 
[**orderControllerPostBuildInfraOrder**](WgOrdersApi.md#ordercontrollerpostbuildinfraorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/buildInfra | 
[**orderControllerPostCancelOrder**](WgOrdersApi.md#ordercontrollerpostcancelorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/cancelOrder/{orderId} | 
[**orderControllerPostDestroyConsOrder**](WgOrdersApi.md#ordercontrollerpostdestroyconsorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/destroyCons | 
[**orderControllerPostDestroyInfraOrder**](WgOrdersApi.md#ordercontrollerpostdestroyinfraorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/destroyInfra | 
[**orderControllerPostFortifyOrder**](WgOrdersApi.md#ordercontrollerpostfortifyorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/fortify | 
[**orderControllerPostMoveOrder**](WgOrdersApi.md#ordercontrollerpostmoveorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/move | 
[**orderControllerPostMoveStockOrder**](WgOrdersApi.md#ordercontrollerpostmovestockorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/movestock | 
[**orderControllerPostPoundOrder**](WgOrdersApi.md#ordercontrollerpostpoundorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/pound | 
[**orderControllerPostSpyOrder**](WgOrdersApi.md#ordercontrollerpostspyorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/spy | 
[**orderControllerPostSurveilOrder**](WgOrdersApi.md#ordercontrollerpostsurveilorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/surveil | 
[**orderControllerPostUnfortifyOrder**](WgOrdersApi.md#ordercontrollerpostunfortifyorder) | **POST** /v1/wgs/{wgId}/orders/phase/{phase}/unfortify | 

<a name="ordercontrollerdeleteallbywgid"></a>
# **orderControllerDeleteAllByWgId**
> void orderControllerDeleteAllByWgId (String wgId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerDeleteAllByWgIdExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id

            try
            {
                apiInstance.orderControllerDeleteAllByWgId(wgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerDeleteAllByWgId: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerdeleteallbywgidandphase"></a>
# **orderControllerDeleteAllByWgIdAndPhase**
> void orderControllerDeleteAllByWgIdAndPhase (String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerDeleteAllByWgIdAndPhaseExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number

            try
            {
                apiInstance.orderControllerDeleteAllByWgIdAndPhase(wgId, phase);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerDeleteAllByWgIdAndPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerdeleteone"></a>
# **orderControllerDeleteOne**
> void orderControllerDeleteOne (String wgId, Integer phase, String orderId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerDeleteOneExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number
            var orderId = orderId_example;  // String | Order id

            try
            {
                apiInstance.orderControllerDeleteOne(wgId, phase, orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerDeleteOne: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 
 **orderId** | **String**| Order id | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerfindall"></a>
# **orderControllerFindAll**
> List orderControllerFindAll (String wgId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerFindAllExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id

            try
            {
                List result = apiInstance.orderControllerFindAll(wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerFindAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 

### Return type

[**List**](WgOrderDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerfindallatphase"></a>
# **orderControllerFindAllAtPhase**
> List orderControllerFindAllAtPhase (String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerFindAllAtPhaseExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number

            try
            {
                List result = apiInstance.orderControllerFindAllAtPhase(wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerFindAllAtPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 

### Return type

[**List**](WgOrderDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerfindbyauth"></a>
# **orderControllerFindByAuth**
> List orderControllerFindByAuth (String wgId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerFindByAuthExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id

            try
            {
                List result = apiInstance.orderControllerFindByAuth(wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerFindByAuth: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 

### Return type

[**List**](WgOrderDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerfindbyauthatphase"></a>
# **orderControllerFindByAuthAtPhase**
> List orderControllerFindByAuthAtPhase (String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerFindByAuthAtPhaseExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number

            try
            {
                List result = apiInstance.orderControllerFindByAuthAtPhase(wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerFindByAuthAtPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 

### Return type

[**List**](WgOrderDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerfinddonebyauthbeforephase"></a>
# **orderControllerFindDoneByAuthBeforePhase**
> List orderControllerFindDoneByAuthBeforePhase (String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerFindDoneByAuthBeforePhaseExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number

            try
            {
                List result = apiInstance.orderControllerFindDoneByAuthBeforePhase(wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerFindDoneByAuthBeforePhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 

### Return type

[**List**](WgOrderDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerfindone"></a>
# **orderControllerFindOne**
> WgOrderDto orderControllerFindOne (String wgId, Integer phase, String orderId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerFindOneExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number
            var orderId = orderId_example;  // String | Order id

            try
            {
                WgOrderDto result = apiInstance.orderControllerFindOne(wgId, phase, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerFindOne: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 
 **orderId** | **String**| Order id | 

### Return type

[**WgOrderDto**](WgOrderDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerfindongoing"></a>
# **orderControllerFindOngoing**
> List orderControllerFindOngoing (String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerFindOngoingExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number

            try
            {
                List result = apiInstance.orderControllerFindOngoing(wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerFindOngoing: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 

### Return type

[**List**](WgOrderDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpatchone"></a>
# **orderControllerPatchOne**
> void orderControllerPatchOne (UpdateWgOrderDto body, String wgId, Integer phase, String orderId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPatchOneExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new UpdateWgOrderDto(); // UpdateWgOrderDto | 
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number
            var orderId = orderId_example;  // String | Order id

            try
            {
                apiInstance.orderControllerPatchOne(body, wgId, phase, orderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPatchOne: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**UpdateWgOrderDto**](UpdateWgOrderDto.md)|  | 
 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 
 **orderId** | **String**| Order id | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostaerialprotectionorder"></a>
# **orderControllerPostAerialProtectionOrder**
> WgStateEntity orderControllerPostAerialProtectionOrder (CreateAerialProtectionOrderDto body, Integer phase, String wgId)



Create a new AerialProtectionOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostAerialProtectionOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateAerialProtectionOrderDto(); // CreateAerialProtectionOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostAerialProtectionOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostAerialProtectionOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateAerialProtectionOrderDto**](CreateAerialProtectionOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostattackorder"></a>
# **orderControllerPostAttackOrder**
> WgStateEntity orderControllerPostAttackOrder (CreateAttackOrderDto body, Integer phase, String wgId)



Create a new AttackOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostAttackOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateAttackOrderDto(); // CreateAttackOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostAttackOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostAttackOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateAttackOrderDto**](CreateAttackOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostbomborder"></a>
# **orderControllerPostBombOrder**
> WgStateEntity orderControllerPostBombOrder (CreateBombOrderDto body, Integer phase, String wgId)



Create a new BombOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostBombOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateBombOrderDto(); // CreateBombOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostBombOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostBombOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateBombOrderDto**](CreateBombOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostbuildconsorder"></a>
# **orderControllerPostBuildConsOrder**
> WgStateEntity orderControllerPostBuildConsOrder (CreateBuildConsOrderDto body, Integer phase, String wgId)



Create a new BuildConsOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostBuildConsOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateBuildConsOrderDto(); // CreateBuildConsOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostBuildConsOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostBuildConsOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateBuildConsOrderDto**](CreateBuildConsOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostbuildinfraorder"></a>
# **orderControllerPostBuildInfraOrder**
> WgStateEntity orderControllerPostBuildInfraOrder (CreateBuildInfraOrderDto body, Integer phase, String wgId)



Create a new BuildInfraOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostBuildInfraOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateBuildInfraOrderDto(); // CreateBuildInfraOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostBuildInfraOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostBuildInfraOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateBuildInfraOrderDto**](CreateBuildInfraOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostcancelorder"></a>
# **orderControllerPostCancelOrder**
> WgStateEntity orderControllerPostCancelOrder (CreateCancelOrderDto body, String wgId, Integer phase, String orderId)



Create a new CancelOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostCancelOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateCancelOrderDto(); // CreateCancelOrderDto | 
            var wgId = wgId_example;  // String | ID of the Wargame
            var phase = 56;  // Integer | Phase number
            var orderId = orderId_example;  // String | OrderId to cancel

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostCancelOrder(body, wgId, phase, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostCancelOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateCancelOrderDto**](CreateCancelOrderDto.md)|  | 
 **wgId** | **String**| ID of the Wargame | 
 **phase** | **Integer**| Phase number | 
 **orderId** | **String**| OrderId to cancel | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostdestroyconsorder"></a>
# **orderControllerPostDestroyConsOrder**
> WgStateEntity orderControllerPostDestroyConsOrder (CreateDestroyConsOrderDto body, Integer phase, String wgId)



Create a new DestroyConsOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostDestroyConsOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateDestroyConsOrderDto(); // CreateDestroyConsOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostDestroyConsOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostDestroyConsOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateDestroyConsOrderDto**](CreateDestroyConsOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostdestroyinfraorder"></a>
# **orderControllerPostDestroyInfraOrder**
> WgStateEntity orderControllerPostDestroyInfraOrder (CreateDestroyInfraOrderDto body, Integer phase, String wgId)



Create a new DestroyInfraOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostDestroyInfraOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateDestroyInfraOrderDto(); // CreateDestroyInfraOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostDestroyInfraOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostDestroyInfraOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateDestroyInfraOrderDto**](CreateDestroyInfraOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostfortifyorder"></a>
# **orderControllerPostFortifyOrder**
> WgStateEntity orderControllerPostFortifyOrder (CreateFortifyOrderDto body, Integer phase, String wgId)



Create a new FortifyOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostFortifyOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateFortifyOrderDto(); // CreateFortifyOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostFortifyOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostFortifyOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateFortifyOrderDto**](CreateFortifyOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostmoveorder"></a>
# **orderControllerPostMoveOrder**
> WgStateEntity orderControllerPostMoveOrder (CreateMoveOrderDto body, String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostMoveOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateMoveOrderDto(); // CreateMoveOrderDto | 
            var wgId = wgId_example;  // String | ID of the Wargame
            var phase = 56;  // Integer | Phase number

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostMoveOrder(body, wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostMoveOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateMoveOrderDto**](CreateMoveOrderDto.md)|  | 
 **wgId** | **String**| ID of the Wargame | 
 **phase** | **Integer**| Phase number | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostmovestockorder"></a>
# **orderControllerPostMoveStockOrder**
> WgStateEntity orderControllerPostMoveStockOrder (CreateMoveStockOrderDto body, Integer phase, String wgId)



Create a new MoveStockOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostMoveStockOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateMoveStockOrderDto(); // CreateMoveStockOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostMoveStockOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostMoveStockOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateMoveStockOrderDto**](CreateMoveStockOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostpoundorder"></a>
# **orderControllerPostPoundOrder**
> WgStateEntity orderControllerPostPoundOrder (CreatePoundOrderDto body, Integer phase, String wgId)



Create a new PoundOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostPoundOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreatePoundOrderDto(); // CreatePoundOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostPoundOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostPoundOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreatePoundOrderDto**](CreatePoundOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostspyorder"></a>
# **orderControllerPostSpyOrder**
> WgStateEntity orderControllerPostSpyOrder (CreateSpyOrderDto body, Integer phase, String wgId)



Create a new SpyOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostSpyOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateSpyOrderDto(); // CreateSpyOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostSpyOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostSpyOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateSpyOrderDto**](CreateSpyOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostsurveilorder"></a>
# **orderControllerPostSurveilOrder**
> WgStateEntity orderControllerPostSurveilOrder (CreateSurveilOrderDto body, Integer phase, String wgId)



Create a new SpyOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostSurveilOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateSurveilOrderDto(); // CreateSurveilOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostSurveilOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostSurveilOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateSurveilOrderDto**](CreateSurveilOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercontrollerpostunfortifyorder"></a>
# **orderControllerPostUnfortifyOrder**
> WgStateEntity orderControllerPostUnfortifyOrder (CreateUnfortifyOrderDto body, Integer phase, String wgId)



Create a new UnfortifyOrder

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class orderControllerPostUnfortifyOrderExample
    {
        public void main()
        {

            var apiInstance = new WgOrdersApi();
            var body = new CreateUnfortifyOrderDto(); // CreateUnfortifyOrderDto | 
            var phase = 56;  // Integer | Phase number
            var wgId = wgId_example;  // String | ID of the Wargame

            try
            {
                WgStateEntity result = apiInstance.orderControllerPostUnfortifyOrder(body, phase, wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgOrdersApi.orderControllerPostUnfortifyOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateUnfortifyOrderDto**](CreateUnfortifyOrderDto.md)|  | 
 **phase** | **Integer**| Phase number | 
 **wgId** | **String**| ID of the Wargame | 

### Return type

[**WgStateEntity**](WgStateEntity.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

