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
using RestSharp;

namespace UnityBestHttp2Client.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
