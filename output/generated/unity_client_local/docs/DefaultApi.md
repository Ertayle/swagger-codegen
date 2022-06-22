# UnityBestHttp2Client.Api.DefaultApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**helloControllerHello**](DefaultApi.md#hellocontrollerhello) | **GET** /v1/hello | 

<a name="hellocontrollerhello"></a>
# **helloControllerHello**
> String helloControllerHello ()



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class helloControllerHelloExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                String result = apiInstance.helloControllerHello();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.helloControllerHello: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**String**](string.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

