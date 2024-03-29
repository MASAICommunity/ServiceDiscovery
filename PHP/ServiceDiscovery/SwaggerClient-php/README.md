# SwaggerClient-php
No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)

This PHP package is automatically generated by the link:https://github.com/swagger-api/swagger-codegen[Swagger Codegen] project:

- API version: v1
- Package version: 1.0.0
- Build package: io.swagger.codegen.languages.PhpClientCodegen

## Requirements

PHP 5.5 and later

## Installation & Usage
### Composer

To install the bindings via link:http://getcomposer.org/[Composer], add the following to `composer.json`:

```
{
  "repositories": [
    {
      "type": "git",
      "url": "https://github.com/GIT_USER_ID/GIT_REPO_ID.git"
    }
  ],
  "require": {
    "GIT_USER_ID/GIT_REPO_ID": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
    require_once('/path/to/SwaggerClient-php/vendor/autoload.php');
```

## Tests

To run the unit tests:

```
composer install
./vendor/bin/phpunit
```

## Getting Started

Please follow the link:#installation--usage[installation procedure] and then run the following:

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new DiscoverySearchEngine\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$discover_apis = new \DiscoverySearchEngine\DiscoverySearchEngine\SearchCriteria(); // \DiscoverySearchEngine\DiscoverySearchEngine\SearchCriteria | Represent a service discovery object, used to performs search queries

try {
    $result = $apiInstance->apiSearchForService($discover_apis);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->apiSearchForService: ', $e->getMessage(), PHP_EOL;
}

?>
```

## anchor:documentation-for-api-endpoints[]Documentation for API Endpoints

All URIs are relative to *http://apis.masai.teleticketing.eu/ServiceDiscovery*

|===
|Class | Method | HTTP request | Description

|*ApiApi* | link:docs/Api/ApiApi.html#apisearchforservice[**apiSearchForService**] | **POST** /api/searchForServices | Search for available services at a specific location
|===

## anchor:documentation-for-models[]Documentation For Models

 - link:docs/Model/Contact.html[Contact]
 - link:docs/Model/Data.html[Data]
 - link:docs/Model/DiscoveryRequest.html[DiscoveryRequest]
 - link:docs/Model/DiscoveryRequestServiceType.html[DiscoveryRequestServiceType]
 - link:docs/Model/JsonExpectedSchema.html[JsonExpectedSchema]
 - link:docs/Model/JsonSchema4.html[JsonSchema4]
 - link:docs/Model/JsonXmlObject.html[JsonXmlObject]
 - link:docs/Model/Location.html[Location]
 - link:docs/Model/Maintainers.html[Maintainers]
 - link:docs/Model/Price.html[Price]
 - link:docs/Model/Properties.html[Properties]
 - link:docs/Model/Rating.html[Rating]
 - link:docs/Model/SearchCriteria.html[SearchCriteria]
 - link:docs/Model/SearchResponse.html[SearchResponse]
 - link:docs/Model/SearchResult.html[SearchResult]
 - link:docs/Model/SwaggerContact.html[SwaggerContact]
 - link:docs/Model/SwaggerDocument.html[SwaggerDocument]
 - link:docs/Model/SwaggerDocumentPaths.html[SwaggerDocumentPaths]
 - link:docs/Model/SwaggerExternalDocumentation.html[SwaggerExternalDocumentation]
 - link:docs/Model/SwaggerInfo.html[SwaggerInfo]
 - link:docs/Model/SwaggerLicense.html[SwaggerLicense]
 - link:docs/Model/SwaggerOperation.html[SwaggerOperation]
 - link:docs/Model/SwaggerParameter.html[SwaggerParameter]
 - link:docs/Model/SwaggerResponse.html[SwaggerResponse]
 - link:docs/Model/SwaggerSecurityScheme.html[SwaggerSecurityScheme]
 - link:docs/Model/SwaggerTag.html[SwaggerTag]


## Documentation For Authorization

 All endpoints do not require authorization.


## Author




