# ServiceDiscovery.DiscoveryRequest

## Properties
|===
|Name | Type | Description | Notes

|**location** | link:Location.html[**Location**] | Location information | [optional] 
|**price** | link:Price.html[**Price**] | Price range information | [optional] 
|**rating** | link:Rating.html[**Rating**] | Rating range information | [optional] 
|**groupOfModule** | **String** | Group of module information (taxi/accomodation/train/flight/bus/tourism/all/car_sharing/bike_sharing/train_station_elevator/train_station_parking/car_rental/restaurant/coworkingspace/public_transport) | 
|**accessKey** | **String** | Google Custom Search Engine Access Key | [optional] 
|**providers** | **[String]** | Search engines selected to search for (If none is selected, then the Service Discovery will search on all search engines) | [optional] 
|**serviceType** | link:DiscoveryRequestServiceType.html[**DiscoveryRequestServiceType**] |  | 
|===


<a name="[ProvidersEnum]"></a>
## Enum: [ProvidersEnum]


* `apis` (value: `"apis"`)

* `google` (value: `"google"`)

* `ckan` (value: `"ckan"`)




