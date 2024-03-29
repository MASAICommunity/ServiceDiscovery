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
import io.swagger.client.model.SearchResponse;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * Search request object
 */
@ApiModel(description = "Search request object")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2018-06-07T16:09:20.617+01:00")
public class SearchResult {
  @SerializedName("searchResponses")
  private Map<String, SearchResponse> searchResponses = null;

  @SerializedName("message")
  private String message = null;

  @SerializedName("status")
  private String status = null;

  @SerializedName("timers")
  private List<String> timers = null;

  public SearchResult searchResponses(Map<String, SearchResponse> searchResponses) {
    this.searchResponses = searchResponses;
    return this;
  }

  public SearchResult putSearchResponsesItem(String key, SearchResponse searchResponsesItem) {
    if (this.searchResponses == null) {
      this.searchResponses = new HashMap<String, SearchResponse>();
    }
    this.searchResponses.put(key, searchResponsesItem);
    return this;
  }

   /**
   * Service information per group of module
   * @return searchResponses
  **/
  @ApiModelProperty(value = "Service information per group of module")
  public Map<String, SearchResponse> getSearchResponses() {
    return searchResponses;
  }

  public void setSearchResponses(Map<String, SearchResponse> searchResponses) {
    this.searchResponses = searchResponses;
  }

  public SearchResult message(String message) {
    this.message = message;
    return this;
  }

   /**
   * Service error message
   * @return message
  **/
  @ApiModelProperty(value = "Service error message")
  public String getMessage() {
    return message;
  }

  public void setMessage(String message) {
    this.message = message;
  }

  public SearchResult status(String status) {
    this.status = status;
    return this;
  }

   /**
   * Status information
   * @return status
  **/
  @ApiModelProperty(value = "Status information")
  public String getStatus() {
    return status;
  }

  public void setStatus(String status) {
    this.status = status;
  }

  public SearchResult timers(List<String> timers) {
    this.timers = timers;
    return this;
  }

  public SearchResult addTimersItem(String timersItem) {
    if (this.timers == null) {
      this.timers = new ArrayList<String>();
    }
    this.timers.add(timersItem);
    return this;
  }

   /**
   * Timer information for each search engine
   * @return timers
  **/
  @ApiModelProperty(value = "Timer information for each search engine")
  public List<String> getTimers() {
    return timers;
  }

  public void setTimers(List<String> timers) {
    this.timers = timers;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SearchResult searchResult = (SearchResult) o;
    return Objects.equals(this.searchResponses, searchResult.searchResponses) &&
        Objects.equals(this.message, searchResult.message) &&
        Objects.equals(this.status, searchResult.status) &&
        Objects.equals(this.timers, searchResult.timers);
  }

  @Override
  public int hashCode() {
    return Objects.hash(searchResponses, message, status, timers);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SearchResult {\n");
    
    sb.append("    searchResponses: ").append(toIndentedString(searchResponses)).append("\n");
    sb.append("    message: ").append(toIndentedString(message)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    timers: ").append(toIndentedString(timers)).append("\n");
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

