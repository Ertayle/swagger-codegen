# UnityBestHttp2Client.Api.UsersApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userControllerCleanupUsersWargame**](UsersApi.md#usercontrollercleanupuserswargame) | **POST** /v1/users/wargames/cleanup | 
[**userControllerCreateUser**](UsersApi.md#usercontrollercreateuser) | **POST** /v1/users | 
[**userControllerDeleteById**](UsersApi.md#usercontrollerdeletebyid) | **DELETE** /v1/users/{id} | 
[**userControllerFindAllUsers**](UsersApi.md#usercontrollerfindallusers) | **GET** /v1/users | 
[**userControllerFindById**](UsersApi.md#usercontrollerfindbyid) | **GET** /v1/users/{id} | 
[**userControllerGetProfile3**](UsersApi.md#usercontrollergetprofile3) | **GET** /v1/users/profile3 | 

<a name="usercontrollercleanupuserswargame"></a>
# **userControllerCleanupUsersWargame**
> void userControllerCleanupUsersWargame ()



Check if Wargame associated to a user are correct

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class userControllerCleanupUsersWargameExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();

            try
            {
                apiInstance.userControllerCleanupUsersWargame();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.userControllerCleanupUsersWargame: " + e.Message );
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

<a name="usercontrollercreateuser"></a>
# **userControllerCreateUser**
> void userControllerCreateUser (UserEntity body)



Create a new user

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class userControllerCreateUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var body = new UserEntity(); // UserEntity | 

            try
            {
                apiInstance.userControllerCreateUser(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.userControllerCreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **body** | [**UserEntity**](UserEntity.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercontrollerdeletebyid"></a>
# **userControllerDeleteById**
> UserPublicInfoDTO userControllerDeleteById (String id)



Delete user by his unique userId

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class userControllerDeleteByIdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var id = id_example;  // String | UserId to query

            try
            {
                UserPublicInfoDTO result = apiInstance.userControllerDeleteById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.userControllerDeleteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **id** | **String**| UserId to query | 

### Return type

[**UserPublicInfoDTO**](UserPublicInfoDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercontrollerfindallusers"></a>
# **userControllerFindAllUsers**
> List userControllerFindAllUsers ()



Find all users

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class userControllerFindAllUsersExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();

            try
            {
                List result = apiInstance.userControllerFindAllUsers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.userControllerFindAllUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List**](UserEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercontrollerfindbyid"></a>
# **userControllerFindById**
> UserPublicInfoDTO userControllerFindById (String id)



Find user by his unique userId

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class userControllerFindByIdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var id = id_example;  // String | UserId to query

            try
            {
                UserPublicInfoDTO result = apiInstance.userControllerFindById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.userControllerFindById: " + e.Message );
            }
        }
    }
}
```

### Parameters

 **id** | **String**| UserId to query | 

### Return type

[**UserPublicInfoDTO**](UserPublicInfoDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercontrollergetprofile3"></a>
# **userControllerGetProfile3**
> UserPublicInfoDTO userControllerGetProfile3 ()



Test endpoint for API Authentication that returns the UserPublicInfoModel

### Example
```csharp
using System;
using System.Diagnostics;
using UnityBestHttp2Client.Api;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace Example
{
    public class userControllerGetProfile3Example
    {
        public void main()
        {

            var apiInstance = new UsersApi();

            try
            {
                UserPublicInfoDTO result = apiInstance.userControllerGetProfile3();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.userControllerGetProfile3: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserPublicInfoDTO**](UserPublicInfoDTO.md)

### Authorization

[bearer](../README.md#bearer), 

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

