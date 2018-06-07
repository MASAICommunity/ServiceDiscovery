/* 
 * MASAI Service Discovery API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
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
using SwaggerDateConverter = ServiceDiscovery.Client.SwaggerDateConverter;

namespace ServiceDiscovery.Model
{
    /// <summary>
    /// JsonExpectedSchema
    /// </summary>
    [DataContract]
    public partial class JsonExpectedSchema :  IEquatable<JsonExpectedSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonExpectedSchema" /> class.
        /// </summary>
        /// <param name="Description">Gets or sets the description..</param>
        /// <param name="Schema">Gets or sets the schema..</param>
        public JsonExpectedSchema(string Description = default(string), JsonSchema4 Schema = default(JsonSchema4))
        {
            this.Description = Description;
            this.Schema = Schema;
        }
        
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>Gets or sets the description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the schema.
        /// </summary>
        /// <value>Gets or sets the schema.</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public JsonSchema4 Schema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonExpectedSchema {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as JsonExpectedSchema);
        }

        /// <summary>
        /// Returns true if JsonExpectedSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonExpectedSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonExpectedSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
