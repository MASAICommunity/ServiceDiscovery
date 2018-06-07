# ServiceDiscovery

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>com.masai.servicediscovery</groupId>
    <artifactId>ServiceDiscovery</artifactId>
    <version>1.0.0</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "com.masai.servicediscovery:ServiceDiscovery:1.0.0"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/ServiceDiscovery-1.0.0.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import io.swagger.client.*;
import io.swagger.client.auth.*;
import io.swagger.client.model.*;
import io.swagger.client.api.DiscoverySearchEngineApi;

import java.io.File;
import java.util.*;

public class DiscoverySearchEngineApiExample {

    public static void main(String[] args) {
        
        DiscoverySearchEngineApi apiInstance = new DiscoverySearchEngineApi();
        SearchCriteria discoverApis = new SearchCriteria(); // SearchCriteria | Represent a service discovery object, used to performs search queries
        try {
            SearchResult result = apiInstance.apiSearchForService(discoverApis);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling DiscoverySearchEngineApi#apiSearchForService");
            e.printStackTrace();
        }
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *http://apis.masai.teleticketing.eu/ServiceDiscovery*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DiscoverySearchEngineApi* | [**apiSearchForService**](docs/DiscoverySearchEngineApi.md#apiSearchForService) | **POST** /api/searchForServices | Search for available services at a specific location


## Documentation for Models

 - [Contact](docs/Contact.md)
 - [Data](docs/Data.md)
 - [DiscoveryRequest](docs/DiscoveryRequest.md)
 - [DiscoveryRequestServiceType](docs/DiscoveryRequestServiceType.md)
 - [JsonExpectedSchema](docs/JsonExpectedSchema.md)
 - [JsonSchema4](docs/JsonSchema4.md)
 - [JsonXmlObject](docs/JsonXmlObject.md)
 - [Location](docs/Location.md)
 - [Maintainers](docs/Maintainers.md)
 - [Price](docs/Price.md)
 - [Properties](docs/Properties.md)
 - [Rating](docs/Rating.md)
 - [SearchCriteria](docs/SearchCriteria.md)
 - [SearchResponse](docs/SearchResponse.md)
 - [SearchResult](docs/SearchResult.md)
 - [SwaggerContact](docs/SwaggerContact.md)
 - [SwaggerDocument](docs/SwaggerDocument.md)
 - [SwaggerDocumentPaths](docs/SwaggerDocumentPaths.md)
 - [SwaggerExternalDocumentation](docs/SwaggerExternalDocumentation.md)
 - [SwaggerInfo](docs/SwaggerInfo.md)
 - [SwaggerLicense](docs/SwaggerLicense.md)
 - [SwaggerOperation](docs/SwaggerOperation.md)
 - [SwaggerParameter](docs/SwaggerParameter.md)
 - [SwaggerResponse](docs/SwaggerResponse.md)
 - [SwaggerSecurityScheme](docs/SwaggerSecurityScheme.md)
 - [SwaggerTag](docs/SwaggerTag.md)


## Documentation for Authorization

All endpoints do not require authorization.
Authentication schemes defined for the API:

## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author



