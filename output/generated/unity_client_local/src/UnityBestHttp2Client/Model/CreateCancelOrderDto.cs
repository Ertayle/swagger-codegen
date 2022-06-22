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
    /// CreateCancelOrderDto
    /// </summary>
    [DataContract]
        public partial class CreateCancelOrderDto :  IEquatable<CreateCancelOrderDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCancelOrderDto" /> class.
        /// </summary>
        /// <param name=""> (required) (default to null).</param>
        /// <param name="">Target Order consistant id (default to null).</param>
        public CreateCancelOrderDto(OrderType  = null, String  = null, )
        {
            // to ensure "" is required (not null)
            if ( == null)
            {
                throw new InvalidDataException(" is a required property for CreateCancelOrderDto and cannot be null");
            }
            else
            {
                this.type = ;
            }
            // use default value if no "" provided
            if ( == null)
            {
                this.targetOrderId = null;
            }
            else
            {
                this.targetOrderId = ;
            }
        }
        
        /// <summary>
        /// Gets or Sets type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=)]
        public OrderType type { get; set; }

        /// <summary>
        /// Target Order consistant id
        /// </summary>
        /// <value>Target Order consistant id</value>
        [DataMember(Name="targetOrderId", EmitDefaultValue=)]
        public String targetOrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCancelOrderDto {\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  targetOrderId: ").Append(targetOrderId).Append("\n");
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
            return this.Equals(input as CreateCancelOrderDto);
        }

        /// <summary>
        /// Returns true if CreateCancelOrderDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCancelOrderDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCancelOrderDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.targetOrderId == input.targetOrderId ||
                    (this.targetOrderId != null &&
                    this.targetOrderId.Equals(input.targetOrderId))
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
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                if (this.targetOrderId != null)
                    hashCode = hashCode * 59 + this.targetOrderId.GetHashCode();
                return hashCode;
            }
        }

    }
}
