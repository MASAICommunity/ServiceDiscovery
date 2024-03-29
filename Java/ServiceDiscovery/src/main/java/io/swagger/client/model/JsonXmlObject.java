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
import java.io.IOException;

/**
 * JsonXmlObject
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2018-06-07T16:09:20.617+01:00")
public class JsonXmlObject {
  @SerializedName("name")
  private String name = null;

  @SerializedName("wrapped")
  private Boolean wrapped = null;

  @SerializedName("namespace")
  private String namespace = null;

  @SerializedName("prefix")
  private String prefix = null;

  @SerializedName("attribute")
  private Boolean attribute = null;

  public JsonXmlObject name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @ApiModelProperty(value = "")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public JsonXmlObject wrapped(Boolean wrapped) {
    this.wrapped = wrapped;
    return this;
  }

   /**
   * Get wrapped
   * @return wrapped
  **/
  @ApiModelProperty(value = "")
  public Boolean isWrapped() {
    return wrapped;
  }

  public void setWrapped(Boolean wrapped) {
    this.wrapped = wrapped;
  }

  public JsonXmlObject namespace(String namespace) {
    this.namespace = namespace;
    return this;
  }

   /**
   * Get namespace
   * @return namespace
  **/
  @ApiModelProperty(value = "")
  public String getNamespace() {
    return namespace;
  }

  public void setNamespace(String namespace) {
    this.namespace = namespace;
  }

  public JsonXmlObject prefix(String prefix) {
    this.prefix = prefix;
    return this;
  }

   /**
   * Get prefix
   * @return prefix
  **/
  @ApiModelProperty(value = "")
  public String getPrefix() {
    return prefix;
  }

  public void setPrefix(String prefix) {
    this.prefix = prefix;
  }

  public JsonXmlObject attribute(Boolean attribute) {
    this.attribute = attribute;
    return this;
  }

   /**
   * Get attribute
   * @return attribute
  **/
  @ApiModelProperty(value = "")
  public Boolean isAttribute() {
    return attribute;
  }

  public void setAttribute(Boolean attribute) {
    this.attribute = attribute;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    JsonXmlObject jsonXmlObject = (JsonXmlObject) o;
    return Objects.equals(this.name, jsonXmlObject.name) &&
        Objects.equals(this.wrapped, jsonXmlObject.wrapped) &&
        Objects.equals(this.namespace, jsonXmlObject.namespace) &&
        Objects.equals(this.prefix, jsonXmlObject.prefix) &&
        Objects.equals(this.attribute, jsonXmlObject.attribute);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, wrapped, namespace, prefix, attribute);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class JsonXmlObject {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    wrapped: ").append(toIndentedString(wrapped)).append("\n");
    sb.append("    namespace: ").append(toIndentedString(namespace)).append("\n");
    sb.append("    prefix: ").append(toIndentedString(prefix)).append("\n");
    sb.append("    attribute: ").append(toIndentedString(attribute)).append("\n");
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

