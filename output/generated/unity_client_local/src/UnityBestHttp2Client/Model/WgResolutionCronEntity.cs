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
    /// WgResolutionCronEntity
    /// </summary>
    [DataContract]
        public partial class WgResolutionCronEntity :  IEquatable<WgResolutionCronEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WgResolutionCronEntity" /> class.
        /// </summary>
        /// <param name="">Wargame ID (required) (default to null).</param>
        /// <param name="">UTC Resolution date (required) (default to null).</param>
        public WgResolutionCronEntity(String  = null, Date  = null, )
        {
            // to ensure "" is required (not null)
            if ( == null)
            {
                throw new InvalidDataException(" is a required property for WgResolutionCronEntity and cannot be null");
            }
            else
            {
                this.wgId = ;
            }
            // to ensure "" is required (not null)
            if ( == null)
            {
                throw new InvalidDataException(" is a required property for WgResolutionCronEntity and cannot be null");
            }
            else
            {
                this.resolutionDate = ;
            }
        }
        
        /// <summary>
        /// Wargame ID
        /// </summary>
        /// <value>Wargame ID</value>
        [DataMember(Name="wgId", EmitDefaultValue=)]
        public String wgId { get; set; }

        /// <summary>
        /// UTC Resolution date
        /// </summary>
        /// <value>UTC Resolution date</value>
        [DataMember(Name="resolutionDate", EmitDefaultValue=)]
        public Date resolutionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WgResolutionCronEntity {\n");
            sb.Append("  wgId: ").Append(wgId).Append("\n");
            sb.Append("  resolutionDate: ").Append(resolutionDate).Append("\n");
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
            return this.Equals(input as WgResolutionCronEntity);
        }

        /// <summary>
        /// Returns true if WgResolutionCronEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of WgResolutionCronEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WgResolutionCronEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.wgId == input.wgId ||
                    (this.wgId != null &&
                    this.wgId.Equals(input.wgId))
                ) && 
                (
                    this.resolutionDate == input.resolutionDate ||
                    (this.resolutionDate != null &&
                    this.resolutionDate.Equals(input.resolutionDate))
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
                if (this.wgId != null)
                    hashCode = hashCode * 59 + this.wgId.GetHashCode();
                if (this.resolutionDate != null)
                    hashCode = hashCode * 59 + this.resolutionDate.GetHashCode();
                return hashCode;
            }
        }

    }
}
