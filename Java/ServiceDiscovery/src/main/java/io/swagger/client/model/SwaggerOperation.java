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
import io.swagger.client.model.SwaggerParameter;
import io.swagger.client.model.SwaggerResponse;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * Describes a JSON web service operation.
 */
@ApiModel(description = "Describes a JSON web service operation.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2018-06-07T16:09:20.617+01:00")
public class SwaggerOperation {
  @SerializedName("tags")
  private List<String> tags = null;

  @SerializedName("summary")
  private String summary = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("externalDocs")
  private SwaggerExternalDocumentation externalDocs = null;

  @SerializedName("operationId")
  private String operationId = null;

  /**
   * Gets or Sets schemes
   */
  @JsonAdapter(SchemesEnum.Adapter.class)
  public enum SchemesEnum {
    UNDEFINED("undefined"),
    
    HTTP("http"),
    
    HTTPS("https"),
    
    WS("ws"),
    
    WSS("wss");

    private String value;

    SchemesEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static SchemesEnum fromValue(String text) {
      for (SchemesEnum b : SchemesEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<SchemesEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final SchemesEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public SchemesEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return SchemesEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("schemes")
  private List<SchemesEnum> schemes = null;

  @SerializedName("consumes")
  private List<String> consumes = null;

  @SerializedName("produces")
  private List<String> produces = null;

  @SerializedName("parameters")
  private List<SwaggerParameter> parameters = null;

  @SerializedName("responses")
  private Map<String, SwaggerResponse> responses = new HashMap<String, SwaggerResponse>();

  @SerializedName("deprecated")
  private Boolean deprecated = null;

  @SerializedName("security")
  private List<Map<String, List<String>>> security = null;

  public SwaggerOperation tags(List<String> tags) {
    this.tags = tags;
    return this;
  }

  public SwaggerOperation addTagsItem(String tagsItem) {
    if (this.tags == null) {
      this.tags = new ArrayList<String>();
    }
    this.tags.add(tagsItem);
    return this;
  }

   /**
   * Gets or sets the tags.
   * @return tags
  **/
  @ApiModelProperty(value = "Gets or sets the tags.")
  public List<String> getTags() {
    return tags;
  }

  public void setTags(List<String> tags) {
    this.tags = tags;
  }

  public SwaggerOperation summary(String summary) {
    this.summary = summary;
    return this;
  }

   /**
   * Gets or sets the summary of the operation.
   * @return summary
  **/
  @ApiModelProperty(value = "Gets or sets the summary of the operation.")
  public String getSummary() {
    return summary;
  }

  public void setSummary(String summary) {
    this.summary = summary;
  }

  public SwaggerOperation description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Gets or sets the long description of the operation.
   * @return description
  **/
  @ApiModelProperty(value = "Gets or sets the long description of the operation.")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public SwaggerOperation externalDocs(SwaggerExternalDocumentation externalDocs) {
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

  public SwaggerOperation operationId(String operationId) {
    this.operationId = operationId;
    return this;
  }

   /**
   * Gets or sets the operation ID (unique name).
   * @return operationId
  **/
  @ApiModelProperty(value = "Gets or sets the operation ID (unique name).")
  public String getOperationId() {
    return operationId;
  }

  public void setOperationId(String operationId) {
    this.operationId = operationId;
  }

  public SwaggerOperation schemes(List<SchemesEnum> schemes) {
    this.schemes = schemes;
    return this;
  }

  public SwaggerOperation addSchemesItem(SchemesEnum schemesItem) {
    if (this.schemes == null) {
      this.schemes = new ArrayList<SchemesEnum>();
    }
    this.schemes.add(schemesItem);
    return this;
  }

   /**
   * Gets or sets the schemes.
   * @return schemes
  **/
  @ApiModelProperty(value = "Gets or sets the schemes.")
  public List<SchemesEnum> getSchemes() {
    return schemes;
  }

  public void setSchemes(List<SchemesEnum> schemes) {
    this.schemes = schemes;
  }

  public SwaggerOperation consumes(List<String> consumes) {
    this.consumes = consumes;
    return this;
  }

  public SwaggerOperation addConsumesItem(String consumesItem) {
    if (this.consumes == null) {
      this.consumes = new ArrayList<String>();
    }
    this.consumes.add(consumesItem);
    return this;
  }

   /**
   * Gets or sets a list of MIME types the operation can consume.
   * @return consumes
  **/
  @ApiModelProperty(value = "Gets or sets a list of MIME types the operation can consume.")
  public List<String> getConsumes() {
    return consumes;
  }

  public void setConsumes(List<String> consumes) {
    this.consumes = consumes;
  }

  public SwaggerOperation produces(List<String> produces) {
    this.produces = produces;
    return this;
  }

  public SwaggerOperation addProducesItem(String producesItem) {
    if (this.produces == null) {
      this.produces = new ArrayList<String>();
    }
    this.produces.add(producesItem);
    return this;
  }

   /**
   * Gets or sets a list of MIME types the operation can produce.
   * @return produces
  **/
  @ApiModelProperty(value = "Gets or sets a list of MIME types the operation can produce.")
  public List<String> getProduces() {
    return produces;
  }

  public void setProduces(List<String> produces) {
    this.produces = produces;
  }

  public SwaggerOperation parameters(List<SwaggerParameter> parameters) {
    this.parameters = parameters;
    return this;
  }

  public SwaggerOperation addParametersItem(SwaggerParameter parametersItem) {
    if (this.parameters == null) {
      this.parameters = new ArrayList<SwaggerParameter>();
    }
    this.parameters.add(parametersItem);
    return this;
  }

   /**
   * Gets or sets the parameters.
   * @return parameters
  **/
  @ApiModelProperty(value = "Gets or sets the parameters.")
  public List<SwaggerParameter> getParameters() {
    return parameters;
  }

  public void setParameters(List<SwaggerParameter> parameters) {
    this.parameters = parameters;
  }

  public SwaggerOperation responses(Map<String, SwaggerResponse> responses) {
    this.responses = responses;
    return this;
  }

  public SwaggerOperation putResponsesItem(String key, SwaggerResponse responsesItem) {
    this.responses.put(key, responsesItem);
    return this;
  }

   /**
   * Gets or sets the HTTP Status Code/Response pairs.
   * @return responses
  **/
  @ApiModelProperty(required = true, value = "Gets or sets the HTTP Status Code/Response pairs.")
  public Map<String, SwaggerResponse> getResponses() {
    return responses;
  }

  public void setResponses(Map<String, SwaggerResponse> responses) {
    this.responses = responses;
  }

  public SwaggerOperation deprecated(Boolean deprecated) {
    this.deprecated = deprecated;
    return this;
  }

   /**
   * Gets or sets a value indicating whether the operation is deprecated.
   * @return deprecated
  **/
  @ApiModelProperty(value = "Gets or sets a value indicating whether the operation is deprecated.")
  public Boolean isDeprecated() {
    return deprecated;
  }

  public void setDeprecated(Boolean deprecated) {
    this.deprecated = deprecated;
  }

  public SwaggerOperation security(List<Map<String, List<String>>> security) {
    this.security = security;
    return this;
  }

  public SwaggerOperation addSecurityItem(Map<String, List<String>> securityItem) {
    if (this.security == null) {
      this.security = new ArrayList<Map<String, List<String>>>();
    }
    this.security.add(securityItem);
    return this;
  }

   /**
   * Gets or sets a security description.
   * @return security
  **/
  @ApiModelProperty(value = "Gets or sets a security description.")
  public List<Map<String, List<String>>> getSecurity() {
    return security;
  }

  public void setSecurity(List<Map<String, List<String>>> security) {
    this.security = security;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SwaggerOperation swaggerOperation = (SwaggerOperation) o;
    return Objects.equals(this.tags, swaggerOperation.tags) &&
        Objects.equals(this.summary, swaggerOperation.summary) &&
        Objects.equals(this.description, swaggerOperation.description) &&
        Objects.equals(this.externalDocs, swaggerOperation.externalDocs) &&
        Objects.equals(this.operationId, swaggerOperation.operationId) &&
        Objects.equals(this.schemes, swaggerOperation.schemes) &&
        Objects.equals(this.consumes, swaggerOperation.consumes) &&
        Objects.equals(this.produces, swaggerOperation.produces) &&
        Objects.equals(this.parameters, swaggerOperation.parameters) &&
        Objects.equals(this.responses, swaggerOperation.responses) &&
        Objects.equals(this.deprecated, swaggerOperation.deprecated) &&
        Objects.equals(this.security, swaggerOperation.security);
  }

  @Override
  public int hashCode() {
    return Objects.hash(tags, summary, description, externalDocs, operationId, schemes, consumes, produces, parameters, responses, deprecated, security);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SwaggerOperation {\n");
    
    sb.append("    tags: ").append(toIndentedString(tags)).append("\n");
    sb.append("    summary: ").append(toIndentedString(summary)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    externalDocs: ").append(toIndentedString(externalDocs)).append("\n");
    sb.append("    operationId: ").append(toIndentedString(operationId)).append("\n");
    sb.append("    schemes: ").append(toIndentedString(schemes)).append("\n");
    sb.append("    consumes: ").append(toIndentedString(consumes)).append("\n");
    sb.append("    produces: ").append(toIndentedString(produces)).append("\n");
    sb.append("    parameters: ").append(toIndentedString(parameters)).append("\n");
    sb.append("    responses: ").append(toIndentedString(responses)).append("\n");
    sb.append("    deprecated: ").append(toIndentedString(deprecated)).append("\n");
    sb.append("    security: ").append(toIndentedString(security)).append("\n");
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

