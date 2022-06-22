# UnityBestHttp2Client.Api.AuthenticationApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**authControllerCreateUser**](AuthenticationApi.md#authcontrollercreateuser) | **POST** /v1/auth/register | 
[**authControllerLogin**](AuthenticationApi.md#authcontrollerlogin) | **POST** /v1/auth/login | 

<a name="authcontrollercreateuser"></a>
# **authControllerCreateUser**
> void authControllerCreateUser (UserRegisterDTO body)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class authControllerCreateUserExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var body = new UserRegisterDTO(); // UserRegisterDTO | 

            try
            {
                apiInstance.authControllerCreateUser(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.authControllerCreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**UserRegisterDTO**](UserRegisterDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authcontrollerlogin"></a>
# **authControllerLogin**
> JwtTokens authControllerLogin (UserLoginDTO body)



### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class authControllerLoginExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var body = new UserLoginDTO(); // UserLoginDTO | 

            try
            {
                JwtTokens result = apiInstance.authControllerLogin(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.authControllerLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**UserLoginDTO**](UserLoginDTO.md)|  | 

### Return type

[**JwtTokens**](JwtTokens.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

