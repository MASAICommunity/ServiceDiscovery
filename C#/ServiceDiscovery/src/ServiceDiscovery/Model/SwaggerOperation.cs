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
    /// Describes a JSON web service operation.
    /// </summary>
    [DataContract]
    public partial class SwaggerOperation :  IEquatable<SwaggerOperation>, IValidatableObject
    {
        /// <summary>
        /// Defines Schemes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemesEnum
        {
            
            /// <summary>
            /// Enum Undefined for value: undefined
            /// </summary>
            [EnumMember(Value = "undefined")]
            Undefined = 1,
            
            /// <summary>
            /// Enum Http for value: http
            /// </summary>
            [EnumMember(Value = "http")]
            Http = 2,
            
            /// <summary>
            /// Enum Https for value: https
            /// </summary>
            [EnumMember(Value = "https")]
            Https = 3,
            
            /// <summary>
            /// Enum Ws for value: ws
            /// </summary>
            [EnumMember(Value = "ws")]
            Ws = 4,
            
            /// <summary>
            /// Enum Wss for value: wss
            /// </summary>
            [EnumMember(Value = "wss")]
            Wss = 5
        }


        /// <summary>
        /// Gets or sets the schemes.
        /// </summary>
        /// <value>Gets or sets the schemes.</value>
        [DataMember(Name="schemes", EmitDefaultValue=false)]
        public List<SchemesEnum> Schemes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerOperation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SwaggerOperation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerOperation" /> class.
        /// </summary>
        /// <param name="Tags">Gets or sets the tags..</param>
        /// <param name="Summary">Gets or sets the summary of the operation..</param>
        /// <param name="Description">Gets or sets the long description of the operation..</param>
        /// <param name="ExternalDocs">Gets or sets the external documentation..</param>
        /// <param name="OperationId">Gets or sets the operation ID (unique name)..</param>
        /// <param name="Schemes">Gets or sets the schemes..</param>
        /// <param name="Consumes">Gets or sets a list of MIME types the operation can consume..</param>
        /// <param name="Produces">Gets or sets a list of MIME types the operation can produce..</param>
        /// <param name="Parameters">Gets or sets the parameters..</param>
        /// <param name="Responses">Gets or sets the HTTP Status Code/Response pairs. (required).</param>
        /// <param name="Deprecated">Gets or sets a value indicating whether the operation is deprecated..</param>
        /// <param name="Security">Gets or sets a security description..</param>
        public SwaggerOperation(List<string> Tags = default(List<string>), string Summary = default(string), string Description = default(string), SwaggerExternalDocumentation ExternalDocs = default(SwaggerExternalDocumentation), string OperationId = default(string), List<SchemesEnum> Schemes = default(List<SchemesEnum>), List<string> Consumes = default(List<string>), List<string> Produces = default(List<string>), List<SwaggerParameter> Parameters = default(List<SwaggerParameter>), Dictionary<string, SwaggerResponse> Responses = default(Dictionary<string, SwaggerResponse>), bool? Deprecated = default(bool?), List<Dictionary<string, List<string>>> Security = default(List<Dictionary<string, List<string>>>))
        {
            // to ensure "Responses" is required (not null)
            if (Responses == null)
            {
                throw new InvalidDataException("Responses is a required property for SwaggerOperation and cannot be null");
            }
            else
            {
                this.Responses = Responses;
            }
            this.Tags = Tags;
            this.Summary = Summary;
            this.Description = Description;
            this.ExternalDocs = ExternalDocs;
            this.OperationId = OperationId;
            this.Schemes = Schemes;
            this.Consumes = Consumes;
            this.Produces = Produces;
            this.Parameters = Parameters;
            this.Deprecated = Deprecated;
            this.Security = Security;
        }
        
        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>Gets or sets the tags.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the summary of the operation.
        /// </summary>
        /// <value>Gets or sets the summary of the operation.</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the long description of the operation.
        /// </summary>
        /// <value>Gets or sets the long description of the operation.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the external documentation.
        /// </summary>
        /// <value>Gets or sets the external documentation.</value>
        [DataMember(Name="externalDocs", EmitDefaultValue=false)]
        public SwaggerExternalDocumentation ExternalDocs { get; set; }

        /// <summary>
        /// Gets or sets the operation ID (unique name).
        /// </summary>
        /// <value>Gets or sets the operation ID (unique name).</value>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }


        /// <summary>
        /// Gets or sets a list of MIME types the operation can consume.
        /// </summary>
        /// <value>Gets or sets a list of MIME types the operation can consume.</value>
        [DataMember(Name="consumes", EmitDefaultValue=false)]
        public List<string> Consumes { get; set; }

        /// <summary>
        /// Gets or sets a list of MIME types the operation can produce.
        /// </summary>
        /// <value>Gets or sets a list of MIME types the operation can produce.</value>
        [DataMember(Name="produces", EmitDefaultValue=false)]
        public List<string> Produces { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        /// <value>Gets or sets the parameters.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<SwaggerParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the HTTP Status Code/Response pairs.
        /// </summary>
        /// <value>Gets or sets the HTTP Status Code/Response pairs.</value>
        [DataMember(Name="responses", EmitDefaultValue=false)]
        public Dictionary<string, SwaggerResponse> Responses { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the operation is deprecated.
        /// </summary>
        /// <value>Gets or sets a value indicating whether the operation is deprecated.</value>
        [DataMember(Name="deprecated", EmitDefaultValue=false)]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Gets or sets a security description.
        /// </summary>
        /// <value>Gets or sets a security description.</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public List<Dictionary<string, List<string>>> Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwaggerOperation {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalDocs: ").Append(ExternalDocs).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Schemes: ").Append(Schemes).Append("\n");
            sb.Append("  Consumes: ").Append(Consumes).Append("\n");
            sb.Append("  Produces: ").Append(Produces).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as SwaggerOperation);
        }

        /// <summary>
        /// Returns true if SwaggerOperation instances are equal
        /// </summary>
        /// <param name="input">Instance of SwaggerOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwaggerOperation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExternalDocs == input.ExternalDocs ||
                    (this.ExternalDocs != null &&
                    this.ExternalDocs.Equals(input.ExternalDocs))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.Schemes == input.Schemes ||
                    this.Schemes != null &&
                    this.Schemes.SequenceEqual(input.Schemes)
                ) && 
                (
                    this.Consumes == input.Consumes ||
                    this.Consumes != null &&
                    this.Consumes.SequenceEqual(input.Consumes)
                ) && 
                (
                    this.Produces == input.Produces ||
                    this.Produces != null &&
                    this.Produces.SequenceEqual(input.Produces)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
                ) && 
                (
                    this.Deprecated == input.Deprecated ||
                    (this.Deprecated != null &&
                    this.Deprecated.Equals(input.Deprecated))
                ) && 
                (
                    this.Security == input.Security ||
                    this.Security != null &&
                    this.Security.SequenceEqual(input.Security)
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExternalDocs != null)
                    hashCode = hashCode * 59 + this.ExternalDocs.GetHashCode();
                if (this.OperationId != null)
                    hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                if (this.Schemes != null)
                    hashCode = hashCode * 59 + this.Schemes.GetHashCode();
                if (this.Consumes != null)
                    hashCode = hashCode * 59 + this.Consumes.GetHashCode();
                if (this.Produces != null)
                    hashCode = hashCode * 59 + this.Produces.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Responses != null)
                    hashCode = hashCode * 59 + this.Responses.GetHashCode();
                if (this.Deprecated != null)
                    hashCode = hashCode * 59 + this.Deprecated.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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