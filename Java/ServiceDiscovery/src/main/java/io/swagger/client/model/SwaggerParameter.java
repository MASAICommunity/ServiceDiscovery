/*
 * MASAI Service Discovery API
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.client.model.JsonSchema4;
import io.swagger.client.model.JsonXmlObject;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * Describes an operation parameter.
 */
@ApiModel(description = "Describes an operation parameter.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2018-06-07T16:09:20.617+01:00")
public class SwaggerParameter {
  @SerializedName("$schema")
  private String schema = null;

  @SerializedName("id")
  private String id = null;

  @SerializedName("title")
  private String title = null;

  @SerializedName("type")
  private Object type = null;

  @SerializedName("discriminator")
  private String discriminator = null;

  @SerializedName("name")
  private String name = null;

  /**
   * Gets or sets the kind of the parameter.
   */
  @JsonAdapter(InEnum.Adapter.class)
  public enum InEnum {
    UNDEFINED("undefined"),
    
    BODY("body"),
    
    QUERY("query"),
    
    PATH("path"),
    
    HEADER("header"),
    
    FORMDATA("formData"),
    
    MODELBINDING("modelbinding");

    private String value;

    InEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static InEnum fromValue(String text) {
      for (InEnum b : InEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<InEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final InEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public InEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return InEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("in")
  private InEnum in = null;

  @SerializedName("required")
  private Boolean required = null;

  @SerializedName("allowEmptyValue")
  private Boolean allowEmptyValue = null;

  @SerializedName("schema")
  private JsonSchema4 schema = null;

  @SerializedName("x-nullable")
  private Boolean xNullable = null;

  /**
   * Gets or sets the format of the array if type array is used.
   */
  @JsonAdapter(CollectionFormatEnum.Adapter.class)
  public enum CollectionFormatEnum {
    UNDEFINED("undefined"),
    
    CSV("csv"),
    
    SSV("ssv"),
    
    TSV("tsv"),
    
    PIPES("pipes"),
    
    MULTI("multi");

    private String value;

    CollectionFormatEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static CollectionFormatEnum fromValue(String text) {
      for (CollectionFormatEnum b : CollectionFormatEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<CollectionFormatEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final CollectionFormatEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public CollectionFormatEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return CollectionFormatEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("collectionFormat")
  private CollectionFormatEnum collectionFormat = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("schemaReferencePath")
  private String schemaReferencePath = null;

  @SerializedName("format")
  private String format = null;

  @SerializedName("default")
  private Object _default = null;

  @SerializedName("multipleOf")
  private Double multipleOf = null;

  @SerializedName("maximum")
  private Double maximum = null;

  @SerializedName("exclusiveMaximum")
  private Boolean exclusiveMaximum = null;

  @SerializedName("minimum")
  private Double minimum = null;

  @SerializedName("exclusiveMinimum")
  private Boolean exclusiveMinimum = null;

  @SerializedName("maxLength")
  private Integer maxLength = null;

  @SerializedName("minLength")
  private Integer minLength = null;

  @SerializedName("pattern")
  private String pattern = null;

  @SerializedName("maxItems")
  private Integer maxItems = null;

  @SerializedName("minItems")
  private Integer minItems = null;

  @SerializedName("uniqueItems")
  private Boolean uniqueItems = null;

  @SerializedName("maxProperties")
  private Integer maxProperties = null;

  @SerializedName("minProperties")
  private Integer minProperties = null;

  @SerializedName("xml")
  private JsonXmlObject xml = null;

  @SerializedName("not")
  private JsonSchema4 not = null;

  @SerializedName("additionalItems")
  private Object additionalItems = null;

  @SerializedName("additionalProperties")
  private Object additionalProperties = null;

  @SerializedName("items")
  private Object items = null;

  @SerializedName("properties")
  private Map<String, JsonSchema4> properties = null;

  @SerializedName("patternProperties")
  private Map<String, JsonSchema4> patternProperties = null;

  @SerializedName("definitions")
  private Map<String, JsonSchema4> definitions = null;

  @SerializedName("x-enumNames")
  private List<String> xEnumNames = null;

  @SerializedName("enum")
  private List<Object> _enum = null;

  @SerializedName("allOf")
  private List<JsonSchema4> allOf = null;

  @SerializedName("anyOf")
  private List<JsonSchema4> anyOf = null;

  @SerializedName("oneOf")
  private List<JsonSchema4> oneOf = null;

  public SwaggerParameter schema(String schema) {
    this.schema = schema;
    return this;
  }

   /**
   * Get schema
   * @return schema
  **/
  @ApiModelProperty(value = "")
  public String getSchema() {
    return schema;
  }

  public void setSchema(String schema) {
    this.schema = schema;
  }

  public SwaggerParameter id(String id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(value = "")
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }

  public SwaggerParameter title(String title) {
    this.title = title;
    return this;
  }

   /**
   * Get title
   * @return title
  **/
  @ApiModelProperty(value = "")
  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

  public SwaggerParameter type(Object type) {
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @ApiModelProperty(value = "")
  public Object getType() {
    return type;
  }

  public void setType(Object type) {
    this.type = type;
  }

  public SwaggerParameter discriminator(String discriminator) {
    this.discriminator = discriminator;
    return this;
  }

   /**
   * Get discriminator
   * @return discriminator
  **/
  @ApiModelProperty(value = "")
  public String getDiscriminator() {
    return discriminator;
  }

  public void setDiscriminator(String discriminator) {
    this.discriminator = discriminator;
  }

  public SwaggerParameter name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Gets or sets the name.
   * @return name
  **/
  @ApiModelProperty(value = "Gets or sets the name.")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public SwaggerParameter in(InEnum in) {
    this.in = in;
    return this;
  }

   /**
   * Gets or sets the kind of the parameter.
   * @return in
  **/
  @ApiModelProperty(value = "Gets or sets the kind of the parameter.")
  public InEnum getIn() {
    return in;
  }

  public void setIn(InEnum in) {
    this.in = in;
  }

  public SwaggerParameter required(Boolean required) {
    this.required = required;
    return this;
  }

   /**
   * Gets or sets a value indicating whether the parameter is required (default: false).
   * @return required
  **/
  @ApiModelProperty(value = "Gets or sets a value indicating whether the parameter is required (default: false).")
  public Boolean isRequired() {
    return required;
  }

  public void setRequired(Boolean required) {
    this.required = required;
  }

  public SwaggerParameter allowEmptyValue(Boolean allowEmptyValue) {
    this.allowEmptyValue = allowEmptyValue;
    return this;
  }

   /**
   * Gets or sets a value indicating whether passing empty-valued parameters is allowed (default: false).
   * @return allowEmptyValue
  **/
  @ApiModelProperty(value = "Gets or sets a value indicating whether passing empty-valued parameters is allowed (default: false).")
  public Boolean isAllowEmptyValue() {
    return allowEmptyValue;
  }

  public void setAllowEmptyValue(Boolean allowEmptyValue) {
    this.allowEmptyValue = allowEmptyValue;
  }

  public SwaggerParameter schema(JsonSchema4 schema) {
    this.schema = schema;
    return this;
  }

   /**
   * Gets or sets the schema which is only available when {NSwag.SwaggerParameter.Kind} &#x3D;&#x3D; body.
   * @return schema
  **/
  @ApiModelProperty(value = "Gets or sets the schema which is only available when {NSwag.SwaggerParameter.Kind} == body.")
  public JsonSchema4 getSchema() {
    return schema;
  }

  public void setSchema(JsonSchema4 schema) {
    this.schema = schema;
  }

  public SwaggerParameter xNullable(Boolean xNullable) {
    this.xNullable = xNullable;
    return this;
  }

   /**
   * Sets a value indicating whether the parameter can be null (use IsNullable() to get a parameter&#39;s nullability).
   * @return xNullable
  **/
  @ApiModelProperty(value = "Sets a value indicating whether the parameter can be null (use IsNullable() to get a parameter's nullability).")
  public Boolean isXNullable() {
    return xNullable;
  }

  public void setXNullable(Boolean xNullable) {
    this.xNullable = xNullable;
  }

  public SwaggerParameter collectionFormat(CollectionFormatEnum collectionFormat) {
    this.collectionFormat = collectionFormat;
    return this;
  }

   /**
   * Gets or sets the format of the array if type array is used.
   * @return collectionFormat
  **/
  @ApiModelProperty(value = "Gets or sets the format of the array if type array is used.")
  public CollectionFormatEnum getCollectionFormat() {
    return collectionFormat;
  }

  public void setCollectionFormat(CollectionFormatEnum collectionFormat) {
    this.collectionFormat = collectionFormat;
  }

  public SwaggerParameter description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(value = "")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public SwaggerParameter schemaReferencePath(String schemaReferencePath) {
    this.schemaReferencePath = schemaReferencePath;
    return this;
  }

   /**
   * Get schemaReferencePath
   * @return schemaReferencePath
  **/
  @ApiModelProperty(value = "")
  public String getSchemaReferencePath() {
    return schemaReferencePath;
  }

  public void setSchemaReferencePath(String schemaReferencePath) {
    this.schemaReferencePath = schemaReferencePath;
  }

  public SwaggerParameter format(String format) {
    this.format = format;
    return this;
  }

   /**
   * Get format
   * @return format
  **/
  @ApiModelProperty(value = "")
  public String getFormat() {
    return format;
  }

  public void setFormat(String format) {
    this.format = format;
  }

  public SwaggerParameter _default(Object _default) {
    this._default = _default;
    return this;
  }

   /**
   * Get _default
   * @return _default
  **/
  @ApiModelProperty(value = "")
  public Object getDefault() {
    return _default;
  }

  public void setDefault(Object _default) {
    this._default = _default;
  }

  public SwaggerParameter multipleOf(Double multipleOf) {
    this.multipleOf = multipleOf;
    return this;
  }

   /**
   * Get multipleOf
   * @return multipleOf
  **/
  @ApiModelProperty(value = "")
  public Double getMultipleOf() {
    return multipleOf;
  }

  public void setMultipleOf(Double multipleOf) {
    this.multipleOf = multipleOf;
  }

  public SwaggerParameter maximum(Double maximum) {
    this.maximum = maximum;
    return this;
  }

   /**
   * Get maximum
   * @return maximum
  **/
  @ApiModelProperty(value = "")
  public Double getMaximum() {
    return maximum;
  }

  public void setMaximum(Double maximum) {
    this.maximum = maximum;
  }

  public SwaggerParameter exclusiveMaximum(Boolean exclusiveMaximum) {
    this.exclusiveMaximum = exclusiveMaximum;
    return this;
  }

   /**
   * Get exclusiveMaximum
   * @return exclusiveMaximum
  **/
  @ApiModelProperty(value = "")
  public Boolean isExclusiveMaximum() {
    return exclusiveMaximum;
  }

  public void setExclusiveMaximum(Boolean exclusiveMaximum) {
    this.exclusiveMaximum = exclusiveMaximum;
  }

  public SwaggerParameter minimum(Double minimum) {
    this.minimum = minimum;
    return this;
  }

   /**
   * Get minimum
   * @return minimum
  **/
  @ApiModelProperty(value = "")
  public Double getMinimum() {
    return minimum;
  }

  public void setMinimum(Double minimum) {
    this.minimum = minimum;
  }

  public SwaggerParameter exclusiveMinimum(Boolean exclusiveMinimum) {
    this.exclusiveMinimum = exclusiveMinimum;
    return this;
  }

   /**
   * Get exclusiveMinimum
   * @return exclusiveMinimum
  **/
  @ApiModelProperty(value = "")
  public Boolean isExclusiveMinimum() {
    return exclusiveMinimum;
  }

  public void setExclusiveMinimum(Boolean exclusiveMinimum) {
    this.exclusiveMinimum = exclusiveMinimum;
  }

  public SwaggerParameter maxLength(Integer maxLength) {
    this.maxLength = maxLength;
    return this;
  }

   /**
   * Get maxLength
   * @return maxLength
  **/
  @ApiModelProperty(value = "")
  public Integer getMaxLength() {
    return maxLength;
  }

  public void setMaxLength(Integer maxLength) {
    this.maxLength = maxLength;
  }

  public SwaggerParameter minLength(Integer minLength) {
    this.minLength = minLength;
    return this;
  }

   /**
   * Get minLength
   * @return minLength
  **/
  @ApiModelProperty(value = "")
  public Integer getMinLength() {
    return minLength;
  }

  public void setMinLength(Integer minLength) {
    this.minLength = minLength;
  }

  public SwaggerParameter pattern(String pattern) {
    this.pattern = pattern;
    return this;
  }

   /**
   * Get pattern
   * @return pattern
  **/
  @ApiModelProperty(value = "")
  public String getPattern() {
    return pattern;
  }

  public void setPattern(String pattern) {
    this.pattern = pattern;
  }

  public SwaggerParameter maxItems(Integer maxItems) {
    this.maxItems = maxItems;
    return this;
  }

   /**
   * Get maxItems
   * @return maxItems
  **/
  @ApiModelProperty(value = "")
  public Integer getMaxItems() {
    return maxItems;
  }

  public void setMaxItems(Integer maxItems) {
    this.maxItems = maxItems;
  }

  public SwaggerParameter minItems(Integer minItems) {
    this.minItems = minItems;
    return this;
  }

   /**
   * Get minItems
   * @return minItems
  **/
  @ApiModelProperty(value = "")
  public Integer getMinItems() {
    return minItems;
  }

  public void setMinItems(Integer minItems) {
    this.minItems = minItems;
  }

  public SwaggerParameter uniqueItems(Boolean uniqueItems) {
    this.uniqueItems = uniqueItems;
    return this;
  }

   /**
   * Get uniqueItems
   * @return uniqueItems
  **/
  @ApiModelProperty(value = "")
  public Boolean isUniqueItems() {
    return uniqueItems;
  }

  public void setUniqueItems(Boolean uniqueItems) {
    this.uniqueItems = uniqueItems;
  }

  public SwaggerParameter maxProperties(Integer maxProperties) {
    this.maxProperties = maxProperties;
    return this;
  }

   /**
   * Get maxProperties
   * @return maxProperties
  **/
  @ApiModelProperty(value = "")
  public Integer getMaxProperties() {
    return maxProperties;
  }

  public void setMaxProperties(Integer maxProperties) {
    this.maxProperties = maxProperties;
  }

  public SwaggerParameter minProperties(Integer minProperties) {
    this.minProperties = minProperties;
    return this;
  }

   /**
   * Get minProperties
   * @return minProperties
  **/
  @ApiModelProperty(value = "")
  public Integer getMinProperties() {
    return minProperties;
  }

  public void setMinProperties(Integer minProperties) {
    this.minProperties = minProperties;
  }

  public SwaggerParameter xml(JsonXmlObject xml) {
    this.xml = xml;
    return this;
  }

   /**
   * Get xml
   * @return xml
  **/
  @ApiModelProperty(value = "")
  public JsonXmlObject getXml() {
    return xml;
  }

  public void setXml(JsonXmlObject xml) {
    this.xml = xml;
  }

  public SwaggerParameter not(JsonSchema4 not) {
    this.not = not;
    return this;
  }

   /**
   * Get not
   * @return not
  **/
  @ApiModelProperty(value = "")
  public JsonSchema4 getNot() {
    return not;
  }

  public void setNot(JsonSchema4 not) {
    this.not = not;
  }

  public SwaggerParameter additionalItems(Object additionalItems) {
    this.additionalItems = additionalItems;
    return this;
  }

   /**
   * Get additionalItems
   * @return additionalItems
  **/
  @ApiModelProperty(value = "")
  public Object getAdditionalItems() {
    return additionalItems;
  }

  public void setAdditionalItems(Object additionalItems) {
    this.additionalItems = additionalItems;
  }

  public SwaggerParameter additionalProperties(Object additionalProperties) {
    this.additionalProperties = additionalProperties;
    return this;
  }

   /**
   * Get additionalProperties
   * @return additionalProperties
  **/
  @ApiModelProperty(value = "")
  public Object getAdditionalProperties() {
    return additionalProperties;
  }

  public void setAdditionalProperties(Object additionalProperties) {
    this.additionalProperties = additionalProperties;
  }

  public SwaggerParameter items(Object items) {
    this.items = items;
    return this;
  }

   /**
   * Get items
   * @return items
  **/
  @ApiModelProperty(value = "")
  public Object getItems() {
    return items;
  }

  public void setItems(Object items) {
    this.items = items;
  }

  public SwaggerParameter properties(Map<String, JsonSchema4> properties) {
    this.properties = properties;
    return this;
  }

  public SwaggerParameter putPropertiesItem(String key, JsonSchema4 propertiesItem) {
    if (this.properties == null) {
      this.properties = new HashMap<String, JsonSchema4>();
    }
    this.properties.put(key, propertiesItem);
    return this;
  }

   /**
   * Get properties
   * @return properties
  **/
  @ApiModelProperty(value = "")
  public Map<String, JsonSchema4> getProperties() {
    return properties;
  }

  public void setProperties(Map<String, JsonSchema4> properties) {
    this.properties = properties;
  }

  public SwaggerParameter patternProperties(Map<String, JsonSchema4> patternProperties) {
    this.patternProperties = patternProperties;
    return this;
  }

  public SwaggerParameter putPatternPropertiesItem(String key, JsonSchema4 patternPropertiesItem) {
    if (this.patternProperties == null) {
      this.patternProperties = new HashMap<String, JsonSchema4>();
    }
    this.patternProperties.put(key, patternPropertiesItem);
    return this;
  }

   /**
   * Get patternProperties
   * @return patternProperties
  **/
  @ApiModelProperty(value = "")
  public Map<String, JsonSchema4> getPatternProperties() {
    return patternProperties;
  }

  public void setPatternProperties(Map<String, JsonSchema4> patternProperties) {
    this.patternProperties = patternProperties;
  }

  public SwaggerParameter definitions(Map<String, JsonSchema4> definitions) {
    this.definitions = definitions;
    return this;
  }

  public SwaggerParameter putDefinitionsItem(String key, JsonSchema4 definitionsItem) {
    if (this.definitions == null) {
      this.definitions = new HashMap<String, JsonSchema4>();
    }
    this.definitions.put(key, definitionsItem);
    return this;
  }

   /**
   * Get definitions
   * @return definitions
  **/
  @ApiModelProperty(value = "")
  public Map<String, JsonSchema4> getDefinitions() {
    return definitions;
  }

  public void setDefinitions(Map<String, JsonSchema4> definitions) {
    this.definitions = definitions;
  }

  public SwaggerParameter xEnumNames(List<String> xEnumNames) {
    this.xEnumNames = xEnumNames;
    return this;
  }

  public SwaggerParameter addXEnumNamesItem(String xEnumNamesItem) {
    if (this.xEnumNames == null) {
      this.xEnumNames = new ArrayList<String>();
    }
    this.xEnumNames.add(xEnumNamesItem);
    return this;
  }

   /**
   * Get xEnumNames
   * @return xEnumNames
  **/
  @ApiModelProperty(value = "")
  public List<String> getXEnumNames() {
    return xEnumNames;
  }

  public void setXEnumNames(List<String> xEnumNames) {
    this.xEnumNames = xEnumNames;
  }

  public SwaggerParameter _enum(List<Object> _enum) {
    this._enum = _enum;
    return this;
  }

  public SwaggerParameter addEnumItem(Object _enumItem) {
    if (this._enum == null) {
      this._enum = new ArrayList<Object>();
    }
    this._enum.add(_enumItem);
    return this;
  }

   /**
   * Get _enum
   * @return _enum
  **/
  @ApiModelProperty(value = "")
  public List<Object> getEnum() {
    return _enum;
  }

  public void setEnum(List<Object> _enum) {
    this._enum = _enum;
  }

  public SwaggerParameter allOf(List<JsonSchema4> allOf) {
    this.allOf = allOf;
    return this;
  }

  public SwaggerParameter addAllOfItem(JsonSchema4 allOfItem) {
    if (this.allOf == null) {
      this.allOf = new ArrayList<JsonSchema4>();
    }
    this.allOf.add(allOfItem);
    return this;
  }

   /**
   * Get allOf
   * @return allOf
  **/
  @ApiModelProperty(value = "")
  public List<JsonSchema4> getAllOf() {
    return allOf;
  }

  public void setAllOf(List<JsonSchema4> allOf) {
    this.allOf = allOf;
  }

  public SwaggerParameter anyOf(List<JsonSchema4> anyOf) {
    this.anyOf = anyOf;
    return this;
  }

  public SwaggerParameter addAnyOfItem(JsonSchema4 anyOfItem) {
    if (this.anyOf == null) {
      this.anyOf = new ArrayList<JsonSchema4>();
    }
    this.anyOf.add(anyOfItem);
    return this;
  }

   /**
   * Get anyOf
   * @return anyOf
  **/
  @ApiModelProperty(value = "")
  public List<JsonSchema4> getAnyOf() {
    return anyOf;
  }

  public void setAnyOf(List<JsonSchema4> anyOf) {
    this.anyOf = anyOf;
  }

  public SwaggerParameter oneOf(List<JsonSchema4> oneOf) {
    this.oneOf = oneOf;
    return this;
  }

  public SwaggerParameter addOneOfItem(JsonSchema4 oneOfItem) {
    if (this.oneOf == null) {
      this.oneOf = new ArrayList<JsonSchema4>();
    }
    this.oneOf.add(oneOfItem);
    return this;
  }

   /**
   * Get oneOf
   * @return oneOf
  **/
  @ApiModelProperty(value = "")
  public List<JsonSchema4> getOneOf() {
    return oneOf;
  }

  public void setOneOf(List<JsonSchema4> oneOf) {
    this.oneOf = oneOf;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SwaggerParameter swaggerParameter = (SwaggerParameter) o;
    return Objects.equals(this.schema, swaggerParameter.schema) &&
        Objects.equals(this.id, swaggerParameter.id) &&
        Objects.equals(this.title, swaggerParameter.title) &&
        Objects.equals(this.type, swaggerParameter.type) &&
        Objects.equals(this.discriminator, swaggerParameter.discriminator) &&
        Objects.equals(this.name, swaggerParameter.name) &&
        Objects.equals(this.in, swaggerParameter.in) &&
        Objects.equals(this.required, swaggerParameter.required) &&
        Objects.equals(this.allowEmptyValue, swaggerParameter.allowEmptyValue) &&
        Objects.equals(this.schema, swaggerParameter.schema) &&
        Objects.equals(this.xNullable, swaggerParameter.xNullable) &&
        Objects.equals(this.collectionFormat, swaggerParameter.collectionFormat) &&
        Objects.equals(this.description, swaggerParameter.description) &&
        Objects.equals(this.schemaReferencePath, swaggerParameter.schemaReferencePath) &&
        Objects.equals(this.format, swaggerParameter.format) &&
        Objects.equals(this._default, swaggerParameter._default) &&
        Objects.equals(this.multipleOf, swaggerParameter.multipleOf) &&
        Objects.equals(this.maximum, swaggerParameter.maximum) &&
        Objects.equals(this.exclusiveMaximum, swaggerParameter.exclusiveMaximum) &&
        Objects.equals(this.minimum, swaggerParameter.minimum) &&
        Objects.equals(this.exclusiveMinimum, swaggerParameter.exclusiveMinimum) &&
        Objects.equals(this.maxLength, swaggerParameter.maxLength) &&
        Objects.equals(this.minLength, swaggerParameter.minLength) &&
        Objects.equals(this.pattern, swaggerParameter.pattern) &&
        Objects.equals(this.maxItems, swaggerParameter.maxItems) &&
        Objects.equals(this.minItems, swaggerParameter.minItems) &&
        Objects.equals(this.uniqueItems, swaggerParameter.uniqueItems) &&
        Objects.equals(this.maxProperties, swaggerParameter.maxProperties) &&
        Objects.equals(this.minProperties, swaggerParameter.minProperties) &&
        Objects.equals(this.xml, swaggerParameter.xml) &&
        Objects.equals(this.not, swaggerParameter.not) &&
        Objects.equals(this.additionalItems, swaggerParameter.additionalItems) &&
        Objects.equals(this.additionalProperties, swaggerParameter.additionalProperties) &&
        Objects.equals(this.items, swaggerParameter.items) &&
        Objects.equals(this.properties, swaggerParameter.properties) &&
        Objects.equals(this.patternProperties, swaggerParameter.patternProperties) &&
        Objects.equals(this.definitions, swaggerParameter.definitions) &&
        Objects.equals(this.xEnumNames, swaggerParameter.xEnumNames) &&
        Objects.equals(this._enum, swaggerParameter._enum) &&
        Objects.equals(this.allOf, swaggerParameter.allOf) &&
        Objects.equals(this.anyOf, swaggerParameter.anyOf) &&
        Objects.equals(this.oneOf, swaggerParameter.oneOf);
  }

  @Override
  public int hashCode() {
    return Objects.hash(schema, id, title, type, discriminator, name, in, required, allowEmptyValue, schema, xNullable, collectionFormat, description, schemaReferencePath, format, _default, multipleOf, maximum, exclusiveMaximum, minimum, exclusiveMinimum, maxLength, minLength, pattern, maxItems, minItems, uniqueItems, maxProperties, minProperties, xml, not, additionalItems, additionalProperties, items, properties, patternProperties, definitions, xEnumNames, _enum, allOf, anyOf, oneOf);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SwaggerParameter {\n");
    
    sb.append("    schema: ").append(toIndentedString(schema)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    discriminator: ").append(toIndentedString(discriminator)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    in: ").append(toIndentedString(in)).append("\n");
    sb.append("    required: ").append(toIndentedString(required)).append("\n");
    sb.append("    allowEmptyValue: ").append(toIndentedString(allowEmptyValue)).append("\n");
    sb.append("    schema: ").append(toIndentedString(schema)).append("\n");
    sb.append("    xNullable: ").append(toIndentedString(xNullable)).append("\n");
    sb.append("    collectionFormat: ").append(toIndentedString(collectionFormat)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    schemaReferencePath: ").append(toIndentedString(schemaReferencePath)).append("\n");
    sb.append("    format: ").append(toIndentedString(format)).append("\n");
    sb.append("    _default: ").append(toIndentedString(_default)).append("\n");
    sb.append("    multipleOf: ").append(toIndentedString(multipleOf)).append("\n");
    sb.append("    maximum: ").append(toIndentedString(maximum)).append("\n");
    sb.append("    exclusiveMaximum: ").append(toIndentedString(exclusiveMaximum)).append("\n");
    sb.append("    minimum: ").append(toIndentedString(minimum)).append("\n");
    sb.append("    exclusiveMinimum: ").append(toIndentedString(exclusiveMinimum)).append("\n");
    sb.append("    maxLength: ").append(toIndentedString(maxLength)).append("\n");
    sb.append("    minLength: ").append(toIndentedString(minLength)).append("\n");
    sb.append("    pattern: ").append(toIndentedString(pattern)).append("\n");
    sb.append("    maxItems: ").append(toIndentedString(maxItems)).append("\n");
    sb.append("    minItems: ").append(toIndentedString(minItems)).append("\n");
    sb.append("    uniqueItems: ").append(toIndentedString(uniqueItems)).append("\n");
    sb.append("    maxProperties: ").append(toIndentedString(maxProperties)).append("\n");
    sb.append("    minProperties: ").append(toIndentedString(minProperties)).append("\n");
    sb.append("    xml: ").append(toIndentedString(xml)).append("\n");
    sb.append("    not: ").append(toIndentedString(not)).append("\n");
    sb.append("    additionalItems: ").append(toIndentedString(additionalItems)).append("\n");
    sb.append("    additionalProperties: ").append(toIndentedString(additionalProperties)).append("\n");
    sb.append("    items: ").append(toIndentedString(items)).append("\n");
    sb.append("    properties: ").append(toIndentedString(properties)).append("\n");
    sb.append("    patternProperties: ").append(toIndentedString(patternProperties)).append("\n");
    sb.append("    definitions: ").append(toIndentedString(definitions)).append("\n");
    sb.append("    xEnumNames: ").append(toIndentedString(xEnumNames)).append("\n");
    sb.append("    _enum: ").append(toIndentedString(_enum)).append("\n");
    sb.append("    allOf: ").append(toIndentedString(allOf)).append("\n");
    sb.append("    anyOf: ").append(toIndentedString(anyOf)).append("\n");
    sb.append("    oneOf: ").append(toIndentedString(oneOf)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
