# UnityBestHttp2Client.Api.WgAdminApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**wgAdminControllerDeleteAllByWgId**](WgAdminApi.md#wgadmincontrollerdeleteallbywgid) | **DELETE** /v1/wgs/{wgId}/admins | 
[**wgAdminControllerDeleteAllByWgIdAndPhase**](WgAdminApi.md#wgadmincontrollerdeleteallbywgidandphase) | **DELETE** /v1/wgs/{wgId}/admins/phase/{phase} | 
[**wgAdminControllerDeleteOne**](WgAdminApi.md#wgadmincontrollerdeleteone) | **DELETE** /v1/wgs/{wgId}/admins/phase/{phase}/{id} | 
[**wgAdminControllerFindAll**](WgAdminApi.md#wgadmincontrollerfindall) | **GET** /v1/wgs/{wgId}/admins | 
[**wgAdminControllerFindAllAtPhase**](WgAdminApi.md#wgadmincontrollerfindallatphase) | **GET** /v1/wgs/{wgId}/admins/phase/{phase} | 
[**wgAdminControllerFindOne**](WgAdminApi.md#wgadmincontrollerfindone) | **GET** /v1/wgs/{wgId}/admins/phase/{phase}/{id} | 
[**wgAdminControllerPatchOne**](WgAdminApi.md#wgadmincontrollerpatchone) | **PATCH** /v1/wgs/{wgId}/admins/phase/{phase}/{id} | 
[**wgAdminControllerPostHandleConstructionsWgAdmin**](WgAdminApi.md#wgadmincontrollerposthandleconstructionswgadmin) | **POST** /v1/wgs/{wgId}/admins/phase/{phase}/handleConstructions | 
[**wgAdminControllerPostHandleCurrenciesWgAdmin**](WgAdminApi.md#wgadmincontrollerposthandlecurrencieswgadmin) | **POST** /v1/wgs/{wgId}/admins/phase/{phase}/handleCurrencies | 
[**wgAdminControllerPostHandleRessourcesWgAdmin**](WgAdminApi.md#wgadmincontrollerposthandleressourceswgadmin) | **POST** /v1/wgs/{wgId}/admins/phase/{phase}/handleRessources | 
[**wgAdminControllerPostSetInfraTypeWgAdmin**](WgAdminApi.md#wgadmincontrollerpostsetinfratypewgadmin) | **POST** /v1/wgs/{wgId}/admins/phase/{phase}/setInfraType | 
[**wgAdminControllerPostSetTerritoryOwnerWgAdmin**](WgAdminApi.md#wgadmincontrollerpostsetterritoryownerwgadmin) | **POST** /v1/wgs/{wgId}/admins/phase/{phase}/setTerritoryOwner | 

<a name="wgadmincontrollerdeleteallbywgid"></a>
# **wgAdminControllerDeleteAllByWgId**
> void wgAdminControllerDeleteAllByWgId (String wgId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerDeleteAllByWgIdExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var wgId = wgId_example;  // String | Wargame id

            try
            {
                apiInstance.wgAdminControllerDeleteAllByWgId(wgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerDeleteAllByWgId: " + e.Message );
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

<a name="wgadmincontrollerdeleteallbywgidandphase"></a>
# **wgAdminControllerDeleteAllByWgIdAndPhase**
> void wgAdminControllerDeleteAllByWgIdAndPhase (String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerDeleteAllByWgIdAndPhaseExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number

            try
            {
                apiInstance.wgAdminControllerDeleteAllByWgIdAndPhase(wgId, phase);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerDeleteAllByWgIdAndPhase: " + e.Message );
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

<a name="wgadmincontrollerdeleteone"></a>
# **wgAdminControllerDeleteOne**
> void wgAdminControllerDeleteOne (String wgId, Integer phase, String id)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerDeleteOneExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number
            var id = id_example;  // String | unique timeuuid

            try
            {
                apiInstance.wgAdminControllerDeleteOne(wgId, phase, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerDeleteOne: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 
 **id** | **String**| unique timeuuid | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgadmincontrollerfindall"></a>
# **wgAdminControllerFindAll**
> List wgAdminControllerFindAll (String wgId)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerFindAllExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var wgId = wgId_example;  // String | Wargame id

            try
            {
                List result = apiInstance.wgAdminControllerFindAll(wgId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerFindAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 

### Return type

[**List**](WgAdminDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgadmincontrollerfindallatphase"></a>
# **wgAdminControllerFindAllAtPhase**
> List wgAdminControllerFindAllAtPhase (String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerFindAllAtPhaseExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number

            try
            {
                List result = apiInstance.wgAdminControllerFindAllAtPhase(wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerFindAllAtPhase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 

### Return type

[**List**](WgAdminDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgadmincontrollerfindone"></a>
# **wgAdminControllerFindOne**
> WgAdminDto wgAdminControllerFindOne (String wgId, Integer phase, String id)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerFindOneExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number
            var id = id_example;  // String | unique timeuuid

            try
            {
                WgAdminDto result = apiInstance.wgAdminControllerFindOne(wgId, phase, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerFindOne: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 
 **id** | **String**| unique timeuuid | 

### Return type

[**WgAdminDto**](WgAdminDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgadmincontrollerpatchone"></a>
# **wgAdminControllerPatchOne**
> void wgAdminControllerPatchOne (UpdateWgAdminDto body, String wgId, Integer phase, String id)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerPatchOneExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var body = new UpdateWgAdminDto(); // UpdateWgAdminDto | 
            var wgId = wgId_example;  // String | Wargame id
            var phase = 56;  // Integer | Phase number
            var id = id_example;  // String | unique timeuuid

            try
            {
                apiInstance.wgAdminControllerPatchOne(body, wgId, phase, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerPatchOne: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**UpdateWgAdminDto**](UpdateWgAdminDto.md)|  | 
 **wgId** | **String**| Wargame id | 
 **phase** | **Integer**| Phase number | 
 **id** | **String**| unique timeuuid | 

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgadmincontrollerposthandleconstructionswgadmin"></a>
# **wgAdminControllerPostHandleConstructionsWgAdmin**
> WgAdminDto wgAdminControllerPostHandleConstructionsWgAdmin (CreateHandleConstructionsWgAdminDto body, String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerPostHandleConstructionsWgAdminExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var body = new CreateHandleConstructionsWgAdminDto(); // CreateHandleConstructionsWgAdminDto | 
            var wgId = wgId_example;  // String | ID of the Wargame
            var phase = 56;  // Integer | Phase number

            try
            {
                WgAdminDto result = apiInstance.wgAdminControllerPostHandleConstructionsWgAdmin(body, wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerPostHandleConstructionsWgAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateHandleConstructionsWgAdminDto**](CreateHandleConstructionsWgAdminDto.md)|  | 
 **wgId** | **String**| ID of the Wargame | 
 **phase** | **Integer**| Phase number | 

### Return type

[**WgAdminDto**](WgAdminDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgadmincontrollerposthandlecurrencieswgadmin"></a>
# **wgAdminControllerPostHandleCurrenciesWgAdmin**
> WgAdminDto wgAdminControllerPostHandleCurrenciesWgAdmin (CreateHandleCurrenciesWgAdminDto body, String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerPostHandleCurrenciesWgAdminExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var body = new CreateHandleCurrenciesWgAdminDto(); // CreateHandleCurrenciesWgAdminDto | 
            var wgId = wgId_example;  // String | ID of the Wargame
            var phase = 56;  // Integer | Phase number

            try
            {
                WgAdminDto result = apiInstance.wgAdminControllerPostHandleCurrenciesWgAdmin(body, wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerPostHandleCurrenciesWgAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateHandleCurrenciesWgAdminDto**](CreateHandleCurrenciesWgAdminDto.md)|  | 
 **wgId** | **String**| ID of the Wargame | 
 **phase** | **Integer**| Phase number | 

### Return type

[**WgAdminDto**](WgAdminDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgadmincontrollerposthandleressourceswgadmin"></a>
# **wgAdminControllerPostHandleRessourcesWgAdmin**
> WgAdminDto wgAdminControllerPostHandleRessourcesWgAdmin (CreateHandleRessourcesWgAdminDto body, String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerPostHandleRessourcesWgAdminExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var body = new CreateHandleRessourcesWgAdminDto(); // CreateHandleRessourcesWgAdminDto | 
            var wgId = wgId_example;  // String | ID of the Wargame
            var phase = 56;  // Integer | Phase number

            try
            {
                WgAdminDto result = apiInstance.wgAdminControllerPostHandleRessourcesWgAdmin(body, wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerPostHandleRessourcesWgAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateHandleRessourcesWgAdminDto**](CreateHandleRessourcesWgAdminDto.md)|  | 
 **wgId** | **String**| ID of the Wargame | 
 **phase** | **Integer**| Phase number | 

### Return type

[**WgAdminDto**](WgAdminDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgadmincontrollerpostsetinfratypewgadmin"></a>
# **wgAdminControllerPostSetInfraTypeWgAdmin**
> WgAdminDto wgAdminControllerPostSetInfraTypeWgAdmin (CreateSetInfraTypeWgAdminDto body, String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerPostSetInfraTypeWgAdminExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var body = new CreateSetInfraTypeWgAdminDto(); // CreateSetInfraTypeWgAdminDto | 
            var wgId = wgId_example;  // String | ID of the Wargame
            var phase = 56;  // Integer | Phase number

            try
            {
                WgAdminDto result = apiInstance.wgAdminControllerPostSetInfraTypeWgAdmin(body, wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerPostSetInfraTypeWgAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateSetInfraTypeWgAdminDto**](CreateSetInfraTypeWgAdminDto.md)|  | 
 **wgId** | **String**| ID of the Wargame | 
 **phase** | **Integer**| Phase number | 

### Return type

[**WgAdminDto**](WgAdminDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wgadmincontrollerpostsetterritoryownerwgadmin"></a>
# **wgAdminControllerPostSetTerritoryOwnerWgAdmin**
> WgAdminDto wgAdminControllerPostSetTerritoryOwnerWgAdmin (CreateSetTerritoryOwnerWgAdminDto body, String wgId, Integer phase)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class wgAdminControllerPostSetTerritoryOwnerWgAdminExample
    {
        public void main()
        {

            var apiInstance = new WgAdminApi();
            var body = new CreateSetTerritoryOwnerWgAdminDto(); // CreateSetTerritoryOwnerWgAdminDto | 
            var wgId = wgId_example;  // String | ID of the Wargame
            var phase = 56;  // Integer | Phase number

            try
            {
                WgAdminDto result = apiInstance.wgAdminControllerPostSetTerritoryOwnerWgAdmin(body, wgId, phase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WgAdminApi.wgAdminControllerPostSetTerritoryOwnerWgAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**CreateSetTerritoryOwnerWgAdminDto**](CreateSetTerritoryOwnerWgAdminDto.md)|  | 
 **wgId** | **String**| ID of the Wargame | 
 **phase** | **Integer**| Phase number | 

### Return type

[**WgAdminDto**](WgAdminDto.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

