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
import io.swagger.client.model.SwaggerExternalDocumentation;
import java.io.IOException;

/**
 * Describes a Swagger tag.
 */
@ApiModel(description = "Describes a Swagger tag.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2018-06-07T16:09:20.617+01:00")
public class SwaggerTag {
  @SerializedName("name")
  private String name = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("externalDocs")
  private SwaggerExternalDocumentation externalDocs = null;

  public SwaggerTag name(String name) {
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

  public SwaggerTag description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Gets or sets the description.
   * @return description
  **/
  @ApiModelProperty(value = "Gets or sets the description.")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public SwaggerTag externalDocs(SwaggerExternalDocumentation externalDocs) {
    this.externalDocs = externalDocs;
    return this;
  }

   /**
   * Gets or sets the external documentation.
   * @return externalDocs
  **/
  @ApiModelProperty(value = "Gets or sets the external documentation.")
  public SwaggerExternalDocumentation getExternalDocs() {
    return externalDocs;
  }

  public void setExternalDocs(SwaggerExternalDocumentation externalDocs) {
    this.externalDocs = externalDocs;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SwaggerTag swaggerTag = (SwaggerTag) o;
    return Objects.equals(this.name, swaggerTag.name) &&
        Objects.equals(this.description, swaggerTag.description) &&
        Objects.equals(this.externalDocs, swaggerTag.externalDocs);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, description, externalDocs);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SwaggerTag {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    externalDocs: ").append(toIndentedString(externalDocs)).append("\n");
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
