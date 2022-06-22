/* 
 * Battlecorp Horizon
 *
 * This documentation is for developpers of the Battlecorp Horizon application. Any usage of this API in time will require a dedicated access token in order to interact with the API.         Pointing to Database Prefix: DEV_sebus
 *
 * OpenAPI spec version: 1.0
 * Contact: contact@fedcom.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using UnityBestHttp2Client.Client;
using UnityBestHttp2Client.Model;

namespace UnityBestHttp2Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface WgResolutionCronApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <param name="phaseNumber"></param>
        /// <returns>WgResolutionCronEntity</returns>
        WgResolutionCronEntity wgResolutionCronControllerCreateWgResolutionCronEntry (String wgId, BigDecimal phaseNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <param name="phaseNumber"></param>
        /// <returns>ApiResponse of WgResolutionCronEntity</returns>
        ApiResponse<WgResolutionCronEntity> wgResolutionCronControllerCreateWgResolutionCronEntryWithHttpInfo (String wgId, BigDecimal phaseNumber);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <returns></returns>
        void wgResolutionCronControllerDeleteWgResolutionCronEntry (String wgId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> wgResolutionCronControllerDeleteWgResolutionCronEntryWithHttpInfo (String wgId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <returns>List</returns>
        List wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDate (String wgId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <returns>ApiResponse of List</returns>
        ApiResponse<List> wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDateWithHttpInfo (String wgId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class WgResolutionCronApi : WgResolutionCronApi
    {
        private UnityBestHttp2Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WgResolutionCronApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WgResolutionCronApi(String basePath)
        {
            this.Configuration = new UnityBestHttp2Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = UnityBestHttp2Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WgResolutionCronApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WgResolutionCronApi(UnityBestHttp2Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = UnityBestHttp2Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = UnityBestHttp2Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public UnityBestHttp2Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public UnityBestHttp2Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <param name="phaseNumber"></param>
        /// <returns>WgResolutionCronEntity</returns>
        public WgResolutionCronEntity wgResolutionCronControllerCreateWgResolutionCronEntry (String wgId, BigDecimal phaseNumber)
        {
             ApiResponse<WgResolutionCronEntity> localVarResponse = wgResolutionCronControllerCreateWgResolutionCronEntryWithHttpInfo(wgId, phaseNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <param name="phaseNumber"></param>
        /// <returns>ApiResponse of WgResolutionCronEntity</returns>
        public ApiResponse< WgResolutionCronEntity > wgResolutionCronControllerCreateWgResolutionCronEntryWithHttpInfo (String wgId, BigDecimal phaseNumber)
        {
            // verify the required parameter 'wgId' is set
            if (wgId == null)
                throw new ApiException(400, "Missing required parameter 'wgId' when calling WgResolutionCronApi->wgResolutionCronControllerCreateWgResolutionCronEntry");
            // verify the required parameter 'phaseNumber' is set
            if (phaseNumber == null)
                throw new ApiException(400, "Missing required parameter 'phaseNumber' when calling WgResolutionCronApi->wgResolutionCronControllerCreateWgResolutionCronEntry");

            var localVarPath = "/v1/wgs/{wgId}/resolution/cron/{phaseNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (wgId != null) localVarPathParams.Add("wgId", this.Configuration.ApiClient.ParameterToString(wgId)); // path parameter
            if (phaseNumber != null) localVarPathParams.Add("phaseNumber", this.Configuration.ApiClient.ParameterToString(phaseNumber)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("wgResolutionCronControllerCreateWgResolutionCronEntry", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WgResolutionCronEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WgResolutionCronEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WgResolutionCronEntity)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <returns></returns>
        public void wgResolutionCronControllerDeleteWgResolutionCronEntry (String wgId)
        {
             wgResolutionCronControllerDeleteWgResolutionCronEntryWithHttpInfo(wgId);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> wgResolutionCronControllerDeleteWgResolutionCronEntryWithHttpInfo (String wgId)
        {
            // verify the required parameter 'wgId' is set
            if (wgId == null)
                throw new ApiException(400, "Missing required parameter 'wgId' when calling WgResolutionCronApi->wgResolutionCronControllerDeleteWgResolutionCronEntry");

            var localVarPath = "/v1/wgs/{wgId}/resolution/cron";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (wgId != null) localVarPathParams.Add("wgId", this.Configuration.ApiClient.ParameterToString(wgId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("wgResolutionCronControllerDeleteWgResolutionCronEntry", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <returns>List</returns>
        public List wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDate (String wgId)
        {
             ApiResponse<List> localVarResponse = wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDateWithHttpInfo(wgId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UnityBestHttp2Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wgId">Id of the Wargame</param>
        /// <returns>ApiResponse of List</returns>
        public ApiResponse< List > wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDateWithHttpInfo (String wgId)
        {
            // verify the required parameter 'wgId' is set
            if (wgId == null)
                throw new ApiException(400, "Missing required parameter 'wgId' when calling WgResolutionCronApi->wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDate");

            var localVarPath = "/v1/wgs/{wgId}/resolution/cron";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (wgId != null) localVarPathParams.Add("wgId", this.Configuration.ApiClient.ParameterToString(wgId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("wgResolutionCronControllerFindAllCronEntriesBeforeCurrentDate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(array)));
        }

    }
}
