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
    /// JsonSchema4
    /// </summary>
    [DataContract]
    public partial class JsonSchema4 :  IEquatable<JsonSchema4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchema4" /> class.
        /// </summary>
        /// <param name="Schema">Schema.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Discriminator">Discriminator.</param>
        /// <param name="Description">Description.</param>
        /// <param name="SchemaReferencePath">SchemaReferencePath.</param>
        /// <param name="Format">Format.</param>
        /// <param name="_Default">_Default.</param>
        /// <param name="MultipleOf">MultipleOf.</param>
        /// <param name="Maximum">Maximum.</param>
        /// <param name="ExclusiveMaximum">ExclusiveMaximum.</param>
        /// <param name="Minimum">Minimum.</param>
        /// <param name="ExclusiveMinimum">ExclusiveMinimum.</param>
        /// <param name="MaxLength">MaxLength.</param>
        /// <param name="MinLength">MinLength.</param>
        /// <param name="Pattern">Pattern.</param>
        /// <param name="MaxItems">MaxItems.</param>
        /// <param name="MinItems">MinItems.</param>
        /// <param name="UniqueItems">UniqueItems.</param>
        /// <param name="MaxProperties">MaxProperties.</param>
        /// <param name="MinProperties">MinProperties.</param>
        /// <param name="Xml">Xml.</param>
        /// <param name="Not">Not.</param>
        /// <param name="AdditionalItems">AdditionalItems.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Items">Items.</param>
        /// <param name="Required">Required.</param>
        /// <param name="Properties">Properties.</param>
        /// <param name="PatternProperties">PatternProperties.</param>
        /// <param name="Definitions">Definitions.</param>
        /// <param name="XEnumNames">XEnumNames.</param>
        /// <param name="_Enum">_Enum.</param>
        /// <param name="AllOf">AllOf.</param>
        /// <param name="AnyOf">AnyOf.</param>
        /// <param name="OneOf">OneOf.</param>
        public JsonSchema4(string Schema = default(string), string Id = default(string), string Title = default(string), Object Type = default(Object), string Discriminator = default(string), string Description = default(string), string SchemaReferencePath = default(string), string Format = default(string), Object _Default = default(Object), double? MultipleOf = default(double?), double? Maximum = default(double?), bool? ExclusiveMaximum = default(bool?), double? Minimum = default(double?), bool? ExclusiveMinimum = default(bool?), int? MaxLength = default(int?), int? MinLength = default(int?), string Pattern = default(string), int? MaxItems = default(int?), int? MinItems = default(int?), bool? UniqueItems = default(bool?), int? MaxProperties = default(int?), int? MinProperties = default(int?), JsonXmlObject Xml = default(JsonXmlObject), JsonSchema4 Not = default(JsonSchema4), Object AdditionalItems = default(Object), Object AdditionalProperties = default(Object), Object Items = default(Object), List<string> Required = default(List<string>), Dictionary<string, JsonSchema4> Properties = default(Dictionary<string, JsonSchema4>), Dictionary<string, JsonSchema4> PatternProperties = default(Dictionary<string, JsonSchema4>), Dictionary<string, JsonSchema4> Definitions = default(Dictionary<string, JsonSchema4>), List<string> XEnumNames = default(List<string>), List<Object> _Enum = default(List<Object>), List<JsonSchema4> AllOf = default(List<JsonSchema4>), List<JsonSchema4> AnyOf = default(List<JsonSchema4>), List<JsonSchema4> OneOf = default(List<JsonSchema4>))
        {
            this.Schema = Schema;
            this.Id = Id;
            this.Title = Title;
            this.Type = Type;
            this.Discriminator = Discriminator;
            this.Description = Description;
            this.SchemaReferencePath = SchemaReferencePath;
            this.Format = Format;
            this._Default = _Default;
            this.MultipleOf = MultipleOf;
            this.Maximum = Maximum;
            this.ExclusiveMaximum = ExclusiveMaximum;
            this.Minimum = Minimum;
            this.ExclusiveMinimum = ExclusiveMinimum;
            this.MaxLength = MaxLength;
            this.MinLength = MinLength;
            this.Pattern = Pattern;
            this.MaxItems = MaxItems;
            this.MinItems = MinItems;
            this.UniqueItems = UniqueItems;
            this.MaxProperties = MaxProperties;
            this.MinProperties = MinProperties;
            this.Xml = Xml;
            this.Not = Not;
            this.AdditionalItems = AdditionalItems;
            this.AdditionalProperties = AdditionalProperties;
            this.Items = Items;
            this.Required = Required;
            this.Properties = Properties;
            this.PatternProperties = PatternProperties;
            this.Definitions = Definitions;
            this.XEnumNames = XEnumNames;
            this._Enum = _Enum;
            this.AllOf = AllOf;
            this.AnyOf = AnyOf;
            this.OneOf = OneOf;
        }
        
        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="$schema", EmitDefaultValue=false)]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public Object Type { get; set; }

        /// <summary>
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name="discriminator", EmitDefaultValue=false)]
        public string Discriminator { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SchemaReferencePath
        /// </summary>
        [DataMember(Name="schemaReferencePath", EmitDefaultValue=false)]
        public string SchemaReferencePath { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public Object _Default { get; set; }

        /// <summary>
        /// Gets or Sets MultipleOf
        /// </summary>
        [DataMember(Name="multipleOf", EmitDefaultValue=false)]
        public double? MultipleOf { get; set; }

        /// <summary>
        /// Gets or Sets Maximum
        /// </summary>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public double? Maximum { get; set; }

        /// <summary>
        /// Gets or Sets ExclusiveMaximum
        /// </summary>
        [DataMember(Name="exclusiveMaximum", EmitDefaultValue=false)]
        public bool? ExclusiveMaximum { get; set; }

        /// <summary>
        /// Gets or Sets Minimum
        /// </summary>
        [DataMember(Name="minimum", EmitDefaultValue=false)]
        public double? Minimum { get; set; }

        /// <summary>
        /// Gets or Sets ExclusiveMinimum
        /// </summary>
        [DataMember(Name="exclusiveMinimum", EmitDefaultValue=false)]
        public bool? ExclusiveMinimum { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets MinLength
        /// </summary>
        [DataMember(Name="minLength", EmitDefaultValue=false)]
        public int? MinLength { get; set; }

        /// <summary>
        /// Gets or Sets Pattern
        /// </summary>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or Sets MaxItems
        /// </summary>
        [DataMember(Name="maxItems", EmitDefaultValue=false)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Gets or Sets MinItems
        /// </summary>
        [DataMember(Name="minItems", EmitDefaultValue=false)]
        public int? MinItems { get; set; }

        /// <summary>
        /// Gets or Sets UniqueItems
        /// </summary>
        [DataMember(Name="uniqueItems", EmitDefaultValue=false)]
        public bool? UniqueItems { get; set; }

        /// <summary>
        /// Gets or Sets MaxProperties
        /// </summary>
        [DataMember(Name="maxProperties", EmitDefaultValue=false)]
        public int? MaxProperties { get; set; }

        /// <summary>
        /// Gets or Sets MinProperties
        /// </summary>
        [DataMember(Name="minProperties", EmitDefaultValue=false)]
        public int? MinProperties { get; set; }

        /// <summary>
        /// Gets or Sets Xml
        /// </summary>
        [DataMember(Name="xml", EmitDefaultValue=false)]
        public JsonXmlObject Xml { get; set; }

        /// <summary>
        /// Gets or Sets Not
        /// </summary>
        [DataMember(Name="not", EmitDefaultValue=false)]
        public JsonSchema4 Not { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalItems
        /// </summary>
        [DataMember(Name="additionalItems", EmitDefaultValue=false)]
        public Object AdditionalItems { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public Object Items { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public List<string> Required { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, JsonSchema4> Properties { get; set; }

        /// <summary>
        /// Gets or Sets PatternProperties
        /// </summary>
        [DataMember(Name="patternProperties", EmitDefaultValue=false)]
        public Dictionary<string, JsonSchema4> PatternProperties { get; set; }

        /// <summary>
        /// Gets or Sets Definitions
        /// </summary>
        [DataMember(Name="definitions", EmitDefaultValue=false)]
        public Dictionary<string, JsonSchema4> Definitions { get; set; }

        /// <summary>
        /// Gets or Sets XEnumNames
        /// </summary>
        [DataMember(Name="x-enumNames", EmitDefaultValue=false)]
        public List<string> XEnumNames { get; set; }

        /// <summary>
        /// Gets or Sets _Enum
        /// </summary>
        [DataMember(Name="enum", EmitDefaultValue=false)]
        public List<Object> _Enum { get; set; }

        /// <summary>
        /// Gets or Sets AllOf
        /// </summary>
        [DataMember(Name="allOf", EmitDefaultValue=false)]
        public List<JsonSchema4> AllOf { get; set; }

        /// <summary>
        /// Gets or Sets AnyOf
        /// </summary>
        [DataMember(Name="anyOf", EmitDefaultValue=false)]
        public List<JsonSchema4> AnyOf { get; set; }

        /// <summary>
        /// Gets or Sets OneOf
        /// </summary>
        [DataMember(Name="oneOf", EmitDefaultValue=false)]
        public List<JsonSchema4> OneOf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonSchema4 {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SchemaReferencePath: ").Append(SchemaReferencePath).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  MultipleOf: ").Append(MultipleOf).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  ExclusiveMaximum: ").Append(ExclusiveMaximum).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  ExclusiveMinimum: ").Append(ExclusiveMinimum).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  MaxItems: ").Append(MaxItems).Append("\n");
            sb.Append("  MinItems: ").Append(MinItems).Append("\n");
            sb.Append("  UniqueItems: ").Append(UniqueItems).Append("\n");
            sb.Append("  MaxProperties: ").Append(MaxProperties).Append("\n");
            sb.Append("  MinProperties: ").Append(MinProperties).Append("\n");
            sb.Append("  Xml: ").Append(Xml).Append("\n");
            sb.Append("  Not: ").Append(Not).Append("\n");
            sb.Append("  AdditionalItems: ").Append(AdditionalItems).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  PatternProperties: ").Append(PatternProperties).Append("\n");
            sb.Append("  Definitions: ").Append(Definitions).Append("\n");
            sb.Append("  XEnumNames: ").Append(XEnumNames).Append("\n");
            sb.Append("  _Enum: ").Append(_Enum).Append("\n");
            sb.Append("  AllOf: ").Append(AllOf).Append("\n");
            sb.Append("  AnyOf: ").Append(AnyOf).Append("\n");
            sb.Append("  OneOf: ").Append(OneOf).Append("\n");
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
            return this.Equals(input as JsonSchema4);
        }

        /// <summary>
        /// Returns true if JsonSchema4 instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonSchema4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonSchema4 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Discriminator == input.Discriminator ||
                    (this.Discriminator != null &&
                    this.Discriminator.Equals(input.Discriminator))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SchemaReferencePath == input.SchemaReferencePath ||
                    (this.SchemaReferencePath != null &&
                    this.SchemaReferencePath.Equals(input.SchemaReferencePath))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this._Default == input._Default ||
                    (this._Default != null &&
                    this._Default.Equals(input._Default))
                ) && 
                (
                    this.MultipleOf == input.MultipleOf ||
                    (this.MultipleOf != null &&
                    this.MultipleOf.Equals(input.MultipleOf))
                ) && 
                (
                    this.Maximum == input.Maximum ||
                    (this.Maximum != null &&
                    this.Maximum.Equals(input.Maximum))
                ) && 
                (
                    this.ExclusiveMaximum == input.ExclusiveMaximum ||
                    (this.ExclusiveMaximum != null &&
                    this.ExclusiveMaximum.Equals(input.ExclusiveMaximum))
                ) && 
                (
                    this.Minimum == input.Minimum ||
                    (this.Minimum != null &&
                    this.Minimum.Equals(input.Minimum))
                ) && 
                (
                    this.ExclusiveMinimum == input.ExclusiveMinimum ||
                    (this.ExclusiveMinimum != null &&
                    this.ExclusiveMinimum.Equals(input.ExclusiveMinimum))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
                ) && 
                (
                    this.MinLength == input.MinLength ||
                    (this.MinLength != null &&
                    this.MinLength.Equals(input.MinLength))
                ) && 
                (
                    this.Pattern == input.Pattern ||
                    (this.Pattern != null &&
                    this.Pattern.Equals(input.Pattern))
                ) && 
                (
                    this.MaxItems == input.MaxItems ||
                    (this.MaxItems != null &&
                    this.MaxItems.Equals(input.MaxItems))
                ) && 
                (
                    this.MinItems == input.MinItems ||
                    (this.MinItems != null &&
                    this.MinItems.Equals(input.MinItems))
                ) && 
                (
                    this.UniqueItems == input.UniqueItems ||
                    (this.UniqueItems != null &&
                    this.UniqueItems.Equals(input.UniqueItems))
                ) && 
                (
                    this.MaxProperties == input.MaxProperties ||
                    (this.MaxProperties != null &&
                    this.MaxProperties.Equals(input.MaxProperties))
                ) && 
                (
                    this.MinProperties == input.MinProperties ||
                    (this.MinProperties != null &&
                    this.MinProperties.Equals(input.MinProperties))
                ) && 
                (
                    this.Xml == input.Xml ||
                    (this.Xml != null &&
                    this.Xml.Equals(input.Xml))
                ) && 
                (
                    this.Not == input.Not ||
                    (this.Not != null &&
                    this.Not.Equals(input.Not))
                ) && 
                (
                    this.AdditionalItems == input.AdditionalItems ||
                    (this.AdditionalItems != null &&
                    this.AdditionalItems.Equals(input.AdditionalItems))
                ) && 
                (
                    this.AdditionalProperties == input.AdditionalProperties ||
                    (this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(input.AdditionalProperties))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required != null &&
                    this.Required.SequenceEqual(input.Required)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.PatternProperties == input.PatternProperties ||
                    this.PatternProperties != null &&
                    this.PatternProperties.SequenceEqual(input.PatternProperties)
                ) && 
                (
                    this.Definitions == input.Definitions ||
                    this.Definitions != null &&
                    this.Definitions.SequenceEqual(input.Definitions)
                ) && 
                (
                    this.XEnumNames == input.XEnumNames ||
                    this.XEnumNames != null &&
                    this.XEnumNames.SequenceEqual(input.XEnumNames)
                ) && 
                (
                    this._Enum == input._Enum ||
                    this._Enum != null &&
                    this._Enum.SequenceEqual(input._Enum)
                ) && 
                (
                    this.AllOf == input.AllOf ||
                    this.AllOf != null &&
                    this.AllOf.SequenceEqual(input.AllOf)
                ) && 
                (
                    this.AnyOf == input.AnyOf ||
                    this.AnyOf != null &&
                    this.AnyOf.SequenceEqual(input.AnyOf)
                ) && 
                (
                    this.OneOf == input.OneOf ||
                    this.OneOf != null &&
                    this.OneOf.SequenceEqual(input.OneOf)
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
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Discriminator != null)
                    hashCode = hashCode * 59 + this.Discriminator.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SchemaReferencePath != null)
                    hashCode = hashCode * 59 + this.SchemaReferencePath.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this._Default != null)
                    hashCode = hashCode * 59 + this._Default.GetHashCode();
                if (this.MultipleOf != null)
                    hashCode = hashCode * 59 + this.MultipleOf.GetHashCode();
                if (this.Maximum != null)
                    hashCode = hashCode * 59 + this.Maximum.GetHashCode();
                if (this.ExclusiveMaximum != null)
                    hashCode = hashCode * 59 + this.ExclusiveMaximum.GetHashCode();
                if (this.Minimum != null)
                    hashCode = hashCode * 59 + this.Minimum.GetHashCode();
                if (this.ExclusiveMinimum != null)
                    hashCode = hashCode * 59 + this.ExclusiveMinimum.GetHashCode();
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.MinLength != null)
                    hashCode = hashCode * 59 + this.MinLength.GetHashCode();
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.MaxItems != null)
                    hashCode = hashCode * 59 + this.MaxItems.GetHashCode();
                if (this.MinItems != null)
                    hashCode = hashCode * 59 + this.MinItems.GetHashCode();
                if (this.UniqueItems != null)
                    hashCode = hashCode * 59 + this.UniqueItems.GetHashCode();
                if (this.MaxProperties != null)
                    hashCode = hashCode * 59 + this.MaxProperties.GetHashCode();
                if (this.MinProperties != null)
                    hashCode = hashCode * 59 + this.MinProperties.GetHashCode();
                if (this.Xml != null)
                    hashCode = hashCode * 59 + this.Xml.GetHashCode();
                if (this.Not != null)
                    hashCode = hashCode * 59 + this.Not.GetHashCode();
                if (this.AdditionalItems != null)
                    hashCode = hashCode * 59 + this.AdditionalItems.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.PatternProperties != null)
                    hashCode = hashCode * 59 + this.PatternProperties.GetHashCode();
                if (this.Definitions != null)
                    hashCode = hashCode * 59 + this.Definitions.GetHashCode();
                if (this.XEnumNames != null)
                    hashCode = hashCode * 59 + this.XEnumNames.GetHashCode();
                if (this._Enum != null)
                    hashCode = hashCode * 59 + this._Enum.GetHashCode();
                if (this.AllOf != null)
                    hashCode = hashCode * 59 + this.AllOf.GetHashCode();
                if (this.AnyOf != null)
                    hashCode = hashCode * 59 + this.AnyOf.GetHashCode();
                if (this.OneOf != null)
                    hashCode = hashCode * 59 + this.OneOf.GetHashCode();
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