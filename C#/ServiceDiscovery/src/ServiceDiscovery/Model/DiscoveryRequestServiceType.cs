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
    /// Combination between the Group of Service and the Integration Mode (E.g.: Search for applications that performs the discovery process &#x3D;&amp;gt; \&quot;discovery\&quot;:\&quot;api\&quot;)
    /// </summary>
    [DataContract]
    public partial class DiscoveryRequestServiceType :  IEquatable<DiscoveryRequestServiceType>, IValidatableObject
    {
        /// <summary>
        /// Defines Discovery
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiscoveryEnum
        {
            
            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 1,
            
            /// <summary>
            /// Enum App for value: app
            /// </summary>
            [EnumMember(Value = "app")]
            App = 2,
            
            /// <summary>
            /// Enum Api for value: api
            /// </summary>
            [EnumMember(Value = "api")]
            Api = 3,
            
            /// <summary>
            /// Enum Deeplink for value: deeplink
            /// </summary>
            [EnumMember(Value = "deeplink")]
            Deeplink = 4,
            
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 5,
            
            /// <summary>
            /// Enum ConciergeWeb for value: ConciergeWeb
            /// </summary>
            [EnumMember(Value = "ConciergeWeb")]
            ConciergeWeb = 6,
            
            /// <summary>
            /// Enum ConciergeApp for value: ConciergeApp
            /// </summary>
            [EnumMember(Value = "ConciergeApp")]
            ConciergeApp = 7,
            
            /// <summary>
            /// Enum ConciergeAPI for value: ConciergeAPI
            /// </summary>
            [EnumMember(Value = "ConciergeAPI")]
            ConciergeAPI = 8,
            
            /// <summary>
            /// Enum ConciergeDeeplink for value: ConciergeDeeplink
            /// </summary>
            [EnumMember(Value = "ConciergeDeeplink")]
            ConciergeDeeplink = 9,
            
            /// <summary>
            /// Enum Widget for value: widget
            /// </summary>
            [EnumMember(Value = "widget")]
            Widget = 10,
            
            /// <summary>
            /// Enum ConciergeWidget for value: ConciergeWidget
            /// </summary>
            [EnumMember(Value = "ConciergeWidget")]
            ConciergeWidget = 11,
            
            /// <summary>
            /// Enum ConciergeDialog for value: ConciergeDialog
            /// </summary>
            [EnumMember(Value = "ConciergeDialog")]
            ConciergeDialog = 12,
            
            /// <summary>
            /// Enum Chatserver for value: chatserver
            /// </summary>
            [EnumMember(Value = "chatserver")]
            Chatserver = 13
        }

        /// <summary>
        /// Gets or Sets Discovery
        /// </summary>
        [DataMember(Name="discovery", EmitDefaultValue=false)]
        public DiscoveryEnum? Discovery { get; set; }
        /// <summary>
        /// Defines Booking
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BookingEnum
        {
            
            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 1,
            
            /// <summary>
            /// Enum App for value: app
            /// </summary>
            [EnumMember(Value = "app")]
            App = 2,
            
            /// <summary>
            /// Enum Api for value: api
            /// </summary>
            [EnumMember(Value = "api")]
            Api = 3,
            
            /// <summary>
            /// Enum Deeplink for value: deeplink
            /// </summary>
            [EnumMember(Value = "deeplink")]
            Deeplink = 4,
            
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 5,
            
            /// <summary>
            /// Enum ConciergeWeb for value: ConciergeWeb
            /// </summary>
            [EnumMember(Value = "ConciergeWeb")]
            ConciergeWeb = 6,
            
            /// <summary>
            /// Enum ConciergeApp for value: ConciergeApp
            /// </summary>
            [EnumMember(Value = "ConciergeApp")]
            ConciergeApp = 7,
            
            /// <summary>
            /// Enum ConciergeAPI for value: ConciergeAPI
            /// </summary>
            [EnumMember(Value = "ConciergeAPI")]
            ConciergeAPI = 8,
            
            /// <summary>
            /// Enum ConciergeDeeplink for value: ConciergeDeeplink
            /// </summary>
            [EnumMember(Value = "ConciergeDeeplink")]
            ConciergeDeeplink = 9,
            
            /// <summary>
            /// Enum Widget for value: widget
            /// </summary>
            [EnumMember(Value = "widget")]
            Widget = 10,
            
            /// <summary>
            /// Enum ConciergeWidget for value: ConciergeWidget
            /// </summary>
            [EnumMember(Value = "ConciergeWidget")]
            ConciergeWidget = 11,
            
            /// <summary>
            /// Enum ConciergeDialog for value: ConciergeDialog
            /// </summary>
            [EnumMember(Value = "ConciergeDialog")]
            ConciergeDialog = 12,
            
            /// <summary>
            /// Enum Chatserver for value: chatserver
            /// </summary>
            [EnumMember(Value = "chatserver")]
            Chatserver = 13
        }

        /// <summary>
        /// Gets or Sets Booking
        /// </summary>
        [DataMember(Name="booking", EmitDefaultValue=false)]
        public BookingEnum? Booking { get; set; }
        /// <summary>
        /// Defines Reschedule
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RescheduleEnum
        {
            
            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 1,
            
            /// <summary>
            /// Enum App for value: app
            /// </summary>
            [EnumMember(Value = "app")]
            App = 2,
            
            /// <summary>
            /// Enum Api for value: api
            /// </summary>
            [EnumMember(Value = "api")]
            Api = 3,
            
            /// <summary>
            /// Enum Deeplink for value: deeplink
            /// </summary>
            [EnumMember(Value = "deeplink")]
            Deeplink = 4,
            
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 5,
            
            /// <summary>
            /// Enum ConciergeWeb for value: ConciergeWeb
            /// </summary>
            [EnumMember(Value = "ConciergeWeb")]
            ConciergeWeb = 6,
            
            /// <summary>
            /// Enum ConciergeApp for value: ConciergeApp
            /// </summary>
            [EnumMember(Value = "ConciergeApp")]
            ConciergeApp = 7,
            
            /// <summary>
            /// Enum ConciergeAPI for value: ConciergeAPI
            /// </summary>
            [EnumMember(Value = "ConciergeAPI")]
            ConciergeAPI = 8,
            
            /// <summary>
            /// Enum ConciergeDeeplink for value: ConciergeDeeplink
            /// </summary>
            [EnumMember(Value = "ConciergeDeeplink")]
            ConciergeDeeplink = 9,
            
            /// <summary>
            /// Enum Widget for value: widget
            /// </summary>
            [EnumMember(Value = "widget")]
            Widget = 10,
            
            /// <summary>
            /// Enum ConciergeWidget for value: ConciergeWidget
            /// </summary>
            [EnumMember(Value = "ConciergeWidget")]
            ConciergeWidget = 11,
            
            /// <summary>
            /// Enum ConciergeDialog for value: ConciergeDialog
            /// </summary>
            [EnumMember(Value = "ConciergeDialog")]
            ConciergeDialog = 12,
            
            /// <summary>
            /// Enum Chatserver for value: chatserver
            /// </summary>
            [EnumMember(Value = "chatserver")]
            Chatserver = 13
        }

        /// <summary>
        /// Gets or Sets Reschedule
        /// </summary>
        [DataMember(Name="reschedule", EmitDefaultValue=false)]
        public RescheduleEnum? Reschedule { get; set; }
        /// <summary>
        /// Defines Info
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InfoEnum
        {
            
            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 1,
            
            /// <summary>
            /// Enum App for value: app
            /// </summary>
            [EnumMember(Value = "app")]
            App = 2,
            
            /// <summary>
            /// Enum Api for value: api
            /// </summary>
            [EnumMember(Value = "api")]
            Api = 3,
            
            /// <summary>
            /// Enum Deeplink for value: deeplink
            /// </summary>
            [EnumMember(Value = "deeplink")]
            Deeplink = 4,
            
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 5,
            
            /// <summary>
            /// Enum ConciergeWeb for value: ConciergeWeb
            /// </summary>
            [EnumMember(Value = "ConciergeWeb")]
            ConciergeWeb = 6,
            
            /// <summary>
            /// Enum ConciergeApp for value: ConciergeApp
            /// </summary>
            [EnumMember(Value = "ConciergeApp")]
            ConciergeApp = 7,
            
            /// <summary>
            /// Enum ConciergeAPI for value: ConciergeAPI
            /// </summary>
            [EnumMember(Value = "ConciergeAPI")]
            ConciergeAPI = 8,
            
            /// <summary>
            /// Enum ConciergeDeeplink for value: ConciergeDeeplink
            /// </summary>
            [EnumMember(Value = "ConciergeDeeplink")]
            ConciergeDeeplink = 9,
            
            /// <summary>
            /// Enum Widget for value: widget
            /// </summary>
            [EnumMember(Value = "widget")]
            Widget = 10,
            
            /// <summary>
            /// Enum ConciergeWidget for value: ConciergeWidget
            /// </summary>
            [EnumMember(Value = "ConciergeWidget")]
            ConciergeWidget = 11,
            
            /// <summary>
            /// Enum ConciergeDialog for value: ConciergeDialog
            /// </summary>
            [EnumMember(Value = "ConciergeDialog")]
            ConciergeDialog = 12,
            
            /// <summary>
            /// Enum Chatserver for value: chatserver
            /// </summary>
            [EnumMember(Value = "chatserver")]
            Chatserver = 13
        }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public InfoEnum? Info { get; set; }
        /// <summary>
        /// Defines All
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllEnum
        {
            
            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 1,
            
            /// <summary>
            /// Enum App for value: app
            /// </summary>
            [EnumMember(Value = "app")]
            App = 2,
            
            /// <summary>
            /// Enum Api for value: api
            /// </summary>
            [EnumMember(Value = "api")]
            Api = 3,
            
            /// <summary>
            /// Enum Deeplink for value: deeplink
            /// </summary>
            [EnumMember(Value = "deeplink")]
            Deeplink = 4,
            
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 5,
            
            /// <summary>
            /// Enum ConciergeWeb for value: ConciergeWeb
            /// </summary>
            [EnumMember(Value = "ConciergeWeb")]
            ConciergeWeb = 6,
            
            /// <summary>
            /// Enum ConciergeApp for value: ConciergeApp
            /// </summary>
            [EnumMember(Value = "ConciergeApp")]
            ConciergeApp = 7,
            
            /// <summary>
            /// Enum ConciergeAPI for value: ConciergeAPI
            /// </summary>
            [EnumMember(Value = "ConciergeAPI")]
            ConciergeAPI = 8,
            
            /// <summary>
            /// Enum ConciergeDeeplink for value: ConciergeDeeplink
            /// </summary>
            [EnumMember(Value = "ConciergeDeeplink")]
            ConciergeDeeplink = 9,
            
            /// <summary>
            /// Enum Widget for value: widget
            /// </summary>
            [EnumMember(Value = "widget")]
            Widget = 10,
            
            /// <summary>
            /// Enum ConciergeWidget for value: ConciergeWidget
            /// </summary>
            [EnumMember(Value = "ConciergeWidget")]
            ConciergeWidget = 11,
            
            /// <summary>
            /// Enum ConciergeDialog for value: ConciergeDialog
            /// </summary>
            [EnumMember(Value = "ConciergeDialog")]
            ConciergeDialog = 12,
            
            /// <summary>
            /// Enum Chatserver for value: chatserver
            /// </summary>
            [EnumMember(Value = "chatserver")]
            Chatserver = 13
        }

        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public AllEnum? All { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveryRequestServiceType" /> class.
        /// </summary>
        /// <param name="Discovery">Discovery.</param>
        /// <param name="Booking">Booking.</param>
        /// <param name="Reschedule">Reschedule.</param>
        /// <param name="Info">Info.</param>
        /// <param name="All">All.</param>
        public DiscoveryRequestServiceType(DiscoveryEnum? Discovery = default(DiscoveryEnum?), BookingEnum? Booking = default(BookingEnum?), RescheduleEnum? Reschedule = default(RescheduleEnum?), InfoEnum? Info = default(InfoEnum?), AllEnum? All = default(AllEnum?))
        {
            this.Discovery = Discovery;
            this.Booking = Booking;
            this.Reschedule = Reschedule;
            this.Info = Info;
            this.All = All;
        }
        





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscoveryRequestServiceType {\n");
            sb.Append("  Discovery: ").Append(Discovery).Append("\n");
            sb.Append("  Booking: ").Append(Booking).Append("\n");
            sb.Append("  Reschedule: ").Append(Reschedule).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
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
            return this.Equals(input as DiscoveryRequestServiceType);
        }

        /// <summary>
        /// Returns true if DiscoveryRequestServiceType instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscoveryRequestServiceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscoveryRequestServiceType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Discovery == input.Discovery ||
                    (this.Discovery != null &&
                    this.Discovery.Equals(input.Discovery))
                ) && 
                (
                    this.Booking == input.Booking ||
                    (this.Booking != null &&
                    this.Booking.Equals(input.Booking))
                ) && 
                (
                    this.Reschedule == input.Reschedule ||
                    (this.Reschedule != null &&
                    this.Reschedule.Equals(input.Reschedule))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
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
                if (this.Discovery != null)
                    hashCode = hashCode * 59 + this.Discovery.GetHashCode();
                if (this.Booking != null)
                    hashCode = hashCode * 59 + this.Booking.GetHashCode();
                if (this.Reschedule != null)
                    hashCode = hashCode * 59 + this.Reschedule.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
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