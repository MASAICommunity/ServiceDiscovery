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
import io.swagger.client.model.JsonExpectedSchema;
import io.swagger.client.model.JsonSchema4;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * The Swagger response.
 */
@ApiModel(description = "The Swagger response.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2018-06-07T16:09:20.617+01:00")
public class SwaggerResponse {
  @SerializedName("description")
  private String description = null;

  @SerializedName("schema")
  private JsonSchema4 schema = null;

  @SerializedName("headers")
  private Map<String, JsonSchema4> headers = null;

  @SerializedName("x-nullable")
  private Boolean xNullable = null;

  @SerializedName("x-expectedSchemas")
  private List<JsonExpectedSchema> xExpectedSchemas = null;

  public SwaggerResponse description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Gets or sets the response&#39;s description.
   * @return description
  **/
  @ApiModelProperty(value = "Gets or sets the response's description.")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public SwaggerResponse schema(JsonSchema4 schema) {
    this.schema = schema;
    return this;
  }

   /**
   * Gets or sets the response schema.
   * @return schema
  **/
  @ApiModelProperty(value = "Gets or sets the response schema.")
  public JsonSchema4 getSchema() {
    return schema;
  }

  public void setSchema(JsonSchema4 schema) {
    this.schema = schema;
  }

  public SwaggerResponse headers(Map<String, JsonSchema4> headers) {
    this.headers = headers;
    return this;
  }

  public SwaggerResponse putHeadersItem(String key, JsonSchema4 headersItem) {
    if (this.headers == null) {
      this.headers = new HashMap<String, JsonSchema4>();
    }
    this.headers.put(key, headersItem);
    return this;
  }

   /**
   * Gets or sets the headers.
   * @return headers
  **/
  @ApiModelProperty(value = "Gets or sets the headers.")
  public Map<String, JsonSchema4> getHeaders() {
    return headers;
  }

  public void setHeaders(Map<String, JsonSchema4> headers) {
    this.headers = headers;
  }

  public SwaggerResponse xNullable(Boolean xNullable) {
    this.xNullable = xNullable;
    return this;
  }

   /**
   * Sets a value indicating whether the response can be null (use IsNullable() to get a parameter&#39;s nullability).
   * @return xNullable
  **/
  @ApiModelProperty(value = "Sets a value indicating whether the response can be null (use IsNullable() to get a parameter's nullability).")
  public Boolean isXNullable() {
    return xNullable;
  }

  public void setXNullable(Boolean xNullable) {
    this.xNullable = xNullable;
  }

  public SwaggerResponse xExpectedSchemas(List<JsonExpectedSchema> xExpectedSchemas) {
    this.xExpectedSchemas = xExpectedSchemas;
    return this;
  }

  public SwaggerResponse addXExpectedSchemasItem(JsonExpectedSchema xExpectedSchemasItem) {
    if (this.xExpectedSchemas == null) {
      this.xExpectedSchemas = new ArrayList<JsonExpectedSchema>();
    }
    this.xExpectedSchemas.add(xExpectedSchemasItem);
    return this;
  }

   /**
   * Gets or sets the expected child schemas of the base schema (can be used for generating enhanced typings/documentation).
   * @return xExpectedSchemas
  **/
  @ApiModelProperty(value = "Gets or sets the expected child schemas of the base schema (can be used for generating enhanced typings/documentation).")
  public List<JsonExpectedSchema> getXExpectedSchemas() {
    return xExpectedSchemas;
  }

  public void setXExpectedSchemas(List<JsonExpectedSchema> xExpectedSchemas) {
    this.xExpectedSchemas = xExpectedSchemas;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SwaggerResponse swaggerResponse = (SwaggerResponse) o;
    return Objects.equals(this.description, swaggerResponse.description) &&
        Objects.equals(this.schema, swaggerResponse.schema) &&
        Objects.equals(this.headers, swaggerResponse.headers) &&
        Objects.equals(this.xNullable, swaggerResponse.xNullable) &&
        Objects.equals(this.xExpectedSchemas, swaggerResponse.xExpectedSchemas);
  }

  @Override
  public int hashCode() {
    return Objects.hash(description, schema, headers, xNullable, xExpectedSchemas);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SwaggerResponse {\n");
    
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    schema: ").append(toIndentedString(schema)).append("\n");
    sb.append("    headers: ").append(toIndentedString(headers)).append("\n");
    sb.append("    xNullable: ").append(toIndentedString(xNullable)).append("\n");
    sb.append("    xExpectedSchemas: ").append(toIndentedString(xExpectedSchemas)).append("\n");
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

