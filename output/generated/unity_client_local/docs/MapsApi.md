# UnityBestHttp2Client.Api.MapsApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mapControllerCreate**](MapsApi.md#mapcontrollercreate) | **POST** /v1/maps | 
[**mapControllerCreateFromJson**](MapsApi.md#mapcontrollercreatefromjson) | **POST** /v1/maps/{name}/{version}/fromJson | 
[**mapControllerDeleteMapVersion**](MapsApi.md#mapcontrollerdeletemapversion) | **DELETE** /v1/maps/{name}/{version} | 
[**mapControllerFindAll**](MapsApi.md#mapcontrollerfindall) | **GET** /v1/maps | 
[**mapControllerFindMap**](MapsApi.md#mapcontrollerfindmap) | **GET** /v1/maps/{name}/{version} | 

<a name="mapcontrollercreate"></a>
# **mapControllerCreate**
> MapEntity mapControllerCreate (MapEntity body)



Create a Map

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class mapControllerCreateExample
    {
        public void main()
        {
            var apiInstance = new MapsApi();
            var body = new MapEntity(); // MapEntity | 

            try
            {
                MapEntity result = apiInstance.mapControllerCreate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapsApi.mapControllerCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**MapEntity**](MapEntity.md)|  | 

### Return type

[**MapEntity**](MapEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapcontrollercreatefromjson"></a>
# **mapControllerCreateFromJson**
> MapEntity mapControllerCreateFromJson (String body, String name, String version)



Add a Map from a JSON preset file content

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class mapControllerCreateFromJsonExample
    {
        public void main()
        {
            var apiInstance = new MapsApi();
            var body = new String(); // String | 
            var name = name_example;  // String | name of the map type
            var version = version_example;  // String | version of the map ( null = \"default\")

            try
            {
                MapEntity result = apiInstance.mapControllerCreateFromJson(body, name, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapsApi.mapControllerCreateFromJson: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**String**](String.md)|  | 
 **name** | **String**| name of the map type | 
 **version** | **String**| version of the map ( null &#x3D; \&quot;default\&quot;) | 

### Return type

[**MapEntity**](MapEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapcontrollerdeletemapversion"></a>
# **mapControllerDeleteMapVersion**
> void mapControllerDeleteMapVersion (String name, String version)



Delete a map version

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class mapControllerDeleteMapVersionExample
    {
        public void main()
        {
            var apiInstance = new MapsApi();
            var name = name_example;  // String | name of the map type
            var version = version_example;  // String | version of the map ( null = \"default\")

            try
            {
                apiInstance.mapControllerDeleteMapVersion(name, version);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapsApi.mapControllerDeleteMapVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **name** | **String**| name of the map type | 
 **version** | **String**| version of the map ( null &#x3D; \&quot;default\&quot;) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapcontrollerfindall"></a>
# **mapControllerFindAll**
> void mapControllerFindAll ()



Get All Maps

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class mapControllerFindAllExample
    {
        public void main()
        {
            var apiInstance = new MapsApi();

            try
            {
                apiInstance.mapControllerFindAll();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapsApi.mapControllerFindAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapcontrollerfindmap"></a>
# **mapControllerFindMap**
> MapEntity mapControllerFindMap (String name, String version)



Get a Map in a specific version

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class mapControllerFindMapExample
    {
        public void main()
        {
            var apiInstance = new MapsApi();
            var name = name_example;  // String | name of the map type
            var version = version_example;  // String | version of the map ( null = \"default\")

            try
            {
                MapEntity result = apiInstance.mapControllerFindMap(name, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapsApi.mapControllerFindMap: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **name** | **String**| name of the map type | 
 **version** | **String**| version of the map ( null &#x3D; \&quot;default\&quot;) | 

### Return type

[**MapEntity**](MapEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

