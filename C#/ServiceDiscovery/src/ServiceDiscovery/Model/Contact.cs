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
    /// Contact
    /// </summary>
    [DataContract]
    public partial class Contact :  IEquatable<Contact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="FullName">Gets or Sets FullName.</param>
        /// <param name="Email">Gets or Sets Email.</param>
        /// <param name="Url">Gets or Sets Url.</param>
        /// <param name="Organization">Gets or Sets Organization.</param>
        /// <param name="Address">Gets or Sets Address.</param>
        /// <param name="Telephone">Gets or Sets Telephone.</param>
        /// <param name="Twitter">Gets or Sets Twitter.</param>
        /// <param name="Github">Gets or Sets Github.</param>
        /// <param name="Photo">Gets or Sets Photo.</param>
        /// <param name="VCard">Gets or Sets VCard.</param>
        public Contact(string FullName = default(string), string Email = default(string), string Url = default(string), string Organization = default(string), string Address = default(string), string Telephone = default(string), string Twitter = default(string), string Github = default(string), string Photo = default(string), string VCard = default(string))
        {
            this.FullName = FullName;
            this.Email = Email;
            this.Url = Url;
            this.Organization = Organization;
            this.Address = Address;
            this.Telephone = Telephone;
            this.Twitter = Twitter;
            this.Github = Github;
            this.Photo = Photo;
            this.VCard = VCard;
        }
        
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        /// <value>Gets or Sets FullName</value>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        /// <value>Gets or Sets Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        /// <value>Gets or Sets Url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        /// <value>Gets or Sets Organization</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        /// <value>Gets or Sets Address</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        /// <value>Gets or Sets Telephone</value>
        [DataMember(Name="telephone", EmitDefaultValue=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        /// <value>Gets or Sets Twitter</value>
        [DataMember(Name="twitter", EmitDefaultValue=false)]
        public string Twitter { get; set; }

        /// <summary>
        /// Gets or Sets Github
        /// </summary>
        /// <value>Gets or Sets Github</value>
        [DataMember(Name="github", EmitDefaultValue=false)]
        public string Github { get; set; }

        /// <summary>
        /// Gets or Sets Photo
        /// </summary>
        /// <value>Gets or Sets Photo</value>
        [DataMember(Name="photo", EmitDefaultValue=false)]
        public string Photo { get; set; }

        /// <summary>
        /// Gets or Sets VCard
        /// </summary>
        /// <value>Gets or Sets VCard</value>
        [DataMember(Name="vCard", EmitDefaultValue=false)]
        public string VCard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Github: ").Append(Github).Append("\n");
            sb.Append("  Photo: ").Append(Photo).Append("\n");
            sb.Append("  VCard: ").Append(VCard).Append("\n");
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
            return this.Equals(input as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="input">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.Twitter == input.Twitter ||
                    (this.Twitter != null &&
                    this.Twitter.Equals(input.Twitter))
                ) && 
                (
                    this.Github == input.Github ||
                    (this.Github != null &&
                    this.Github.Equals(input.Github))
                ) && 
                (
                    this.Photo == input.Photo ||
                    (this.Photo != null &&
                    this.Photo.Equals(input.Photo))
                ) && 
                (
                    this.VCard == input.VCard ||
                    (this.VCard != null &&
                    this.VCard.Equals(input.VCard))
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
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Telephone != null)
                    hashCode = hashCode * 59 + this.Telephone.GetHashCode();
                if (this.Twitter != null)
                    hashCode = hashCode * 59 + this.Twitter.GetHashCode();
                if (this.Github != null)
                    hashCode = hashCode * 59 + this.Github.GetHashCode();
                if (this.Photo != null)
                    hashCode = hashCode * 59 + this.Photo.GetHashCode();
                if (this.VCard != null)
                    hashCode = hashCode * 59 + this.VCard.GetHashCode();
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
