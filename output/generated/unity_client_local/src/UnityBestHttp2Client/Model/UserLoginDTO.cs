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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = UnityBestHttp2Client.Client.SwaggerDateConverter;

namespace UnityBestHttp2Client.Model
{
    /// <summary>
    /// UserLoginDTO
    /// </summary>
    [DataContract]
        public partial class UserLoginDTO :  IEquatable<UserLoginDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLoginDTO" /> class.
        /// </summary>
        /// <param name="">Ingame player name (unique) (required) (default to null).</param>
        /// <param name="">User password (default to null).</param>
        public UserLoginDTO(String  = null, String  = null, )
        {
            // to ensure "" is required (not null)
            if ( == null)
            {
                throw new InvalidDataException(" is a required property for UserLoginDTO and cannot be null");
            }
            else
            {
                this.username = ;
            }
            // use default value if no "" provided
            if ( == null)
            {
                this.password = null;
            }
            else
            {
                this.password = ;
            }
        }
        
        /// <summary>
        /// Ingame player name (unique)
        /// </summary>
        /// <value>Ingame player name (unique)</value>
        [DataMember(Name="username", EmitDefaultValue=)]
        public String username { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        /// <value>User password</value>
        [DataMember(Name="password", EmitDefaultValue=)]
        public String password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLoginDTO {\n");
            sb.Append("  username: ").Append(username).Append("\n");
            sb.Append("  password: ").Append(password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserLoginDTO);
        }

        /// <summary>
        /// Returns true if UserLoginDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLoginDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLoginDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.username == input.username ||
                    (this.username != null &&
                    this.username.Equals(input.username))
                ) && 
                (
                    this.password == input.password ||
                    (this.password != null &&
                    this.password.Equals(input.password))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.username != null)
                    hashCode = hashCode * 59 + this.username.GetHashCode();
                if (this.password != null)
                    hashCode = hashCode * 59 + this.password.GetHashCode();
                return hashCode;
            }
        }

    }
}
