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
 * Contact
 */
@ApiModel(description = "Contact")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2018-06-07T16:09:20.617+01:00")
public class Contact {
  @SerializedName("fullName")
  private String fullName = null;

  @SerializedName("email")
  private String email = null;

  @SerializedName("url")
  private String url = null;

  @SerializedName("organization")
  private String organization = null;

  @SerializedName("address")
  private String address = null;

  @SerializedName("telephone")
  private String telephone = null;

  @SerializedName("twitter")
  private String twitter = null;

  @SerializedName("github")
  private String github = null;

  @SerializedName("photo")
  private String photo = null;

  @SerializedName("vCard")
  private String vCard = null;

  public Contact fullName(String fullName) {
    this.fullName = fullName;
    return this;
  }

   /**
   * Gets or Sets FullName
   * @return fullName
  **/
  @ApiModelProperty(value = "Gets or Sets FullName")
  public String getFullName() {
    return fullName;
  }

  public void setFullName(String fullName) {
    this.fullName = fullName;
  }

  public Contact email(String email) {
    this.email = email;
    return this;
  }

   /**
   * Gets or Sets Email
   * @return email
  **/
  @ApiModelProperty(value = "Gets or Sets Email")
  public String getEmail() {
    return email;
  }

  public void setEmail(String email) {
    this.email = email;
  }

  public Contact url(String url) {
    this.url = url;
    return this;
  }

   /**
   * Gets or Sets Url
   * @return url
  **/
  @ApiModelProperty(value = "Gets or Sets Url")
  public String getUrl() {
    return url;
  }

  public void setUrl(String url) {
    this.url = url;
  }

  public Contact organization(String organization) {
    this.organization = organization;
    return this;
  }

   /**
   * Gets or Sets Organization
   * @return organization
  **/
  @ApiModelProperty(value = "Gets or Sets Organization")
  public String getOrganization() {
    return organization;
  }

  public void setOrganization(String organization) {
    this.organization = organization;
  }

  public Contact address(String address) {
    this.address = address;
    return this;
  }

   /**
   * Gets or Sets Address
   * @return address
  **/
  @ApiModelProperty(value = "Gets or Sets Address")
  public String getAddress() {
    return address;
  }

  public void setAddress(String address) {
    this.address = address;
  }

  public Contact telephone(String telephone) {
    this.telephone = telephone;
    return this;
  }

   /**
   * Gets or Sets Telephone
   * @return telephone
  **/
  @ApiModelProperty(value = "Gets or Sets Telephone")
  public String getTelephone() {
    return telephone;
  }

  public void setTelephone(String telephone) {
    this.telephone = telephone;
  }

  public Contact twitter(String twitter) {
    this.twitter = twitter;
    return this;
  }

   /**
   * Gets or Sets Twitter
   * @return twitter
  **/
  @ApiModelProperty(value = "Gets or Sets Twitter")
  public String getTwitter() {
    return twitter;
  }

  public void setTwitter(String twitter) {
    this.twitter = twitter;
  }

  public Contact github(String github) {
    this.github = github;
    return this;
  }

   /**
   * Gets or Sets Github
   * @return github
  **/
  @ApiModelProperty(value = "Gets or Sets Github")
  public String getGithub() {
    return github;
  }

  public void setGithub(String github) {
    this.github = github;
  }

  public Contact photo(String photo) {
    this.photo = photo;
    return this;
  }

   /**
   * Gets or Sets Photo
   * @return photo
  **/
  @ApiModelProperty(value = "Gets or Sets Photo")
  public String getPhoto() {
    return photo;
  }

  public void setPhoto(String photo) {
    this.photo = photo;
  }

  public Contact vCard(String vCard) {
    this.vCard = vCard;
    return this;
  }

   /**
   * Gets or Sets VCard
   * @return vCard
  **/
  @ApiModelProperty(value = "Gets or Sets VCard")
  public String getVCard() {
    return vCard;
  }

  public void setVCard(String vCard) {
    this.vCard = vCard;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Contact contact = (Contact) o;
    return Objects.equals(this.fullName, contact.fullName) &&
        Objects.equals(this.email, contact.email) &&
        Objects.equals(this.url, contact.url) &&
        Objects.equals(this.organization, contact.organization) &&
        Objects.equals(this.address, contact.address) &&
        Objects.equals(this.telephone, contact.telephone) &&
        Objects.equals(this.twitter, contact.twitter) &&
        Objects.equals(this.github, contact.github) &&
        Objects.equals(this.photo, contact.photo) &&
        Objects.equals(this.vCard, contact.vCard);
  }

  @Override
  public int hashCode() {
    return Objects.hash(fullName, email, url, organization, address, telephone, twitter, github, photo, vCard);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Contact {\n");
    
    sb.append("    fullName: ").append(toIndentedString(fullName)).append("\n");
    sb.append("    email: ").append(toIndentedString(email)).append("\n");
    sb.append("    url: ").append(toIndentedString(url)).append("\n");
    sb.append("    organization: ").append(toIndentedString(organization)).append("\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
    sb.append("    telephone: ").append(toIndentedString(telephone)).append("\n");
    sb.append("    twitter: ").append(toIndentedString(twitter)).append("\n");
    sb.append("    github: ").append(toIndentedString(github)).append("\n");
    sb.append("    photo: ").append(toIndentedString(photo)).append("\n");
    sb.append("    vCard: ").append(toIndentedString(vCard)).append("\n");
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
