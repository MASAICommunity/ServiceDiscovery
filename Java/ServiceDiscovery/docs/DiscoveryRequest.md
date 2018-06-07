
# DiscoveryRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**location** | [**Location**](Location.md) | Location information |  [optional]
**price** | [**Price**](Price.md) | Price range information |  [optional]
**rating** | [**Rating**](Rating.md) | Rating range information |  [optional]
**groupOfModule** | **String** | Group of module information (taxi|accomodation|train|flight|bus|tourism|all|car_sharing|bike_sharing|train_station_elevator|train_station_parking|car_rental|restaurant|coworkingspace|public_transport) | 
**accessKey** | **String** | Google Custom Search Engine Access Key |  [optional]
**providers** | [**List&lt;ProvidersEnum&gt;**](#List&lt;ProvidersEnum&gt;) | Search engines selected to search for (If none is selected, then the Service Discovery will search on all search engines) |  [optional]
**serviceType** | [**DiscoveryRequestServiceType**](DiscoveryRequestServiceType.md) |  | 


<a name="List<ProvidersEnum>"></a>
## Enum: List&lt;ProvidersEnum&gt;
Name | Value
---- | -----
APIS | &quot;apis&quot;
GOOGLE | &quot;google&quot;
CKAN | &quot;ckan&quot;



