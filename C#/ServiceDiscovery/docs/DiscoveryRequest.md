# ServiceDiscovery.Model.DiscoveryRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Location** | [**Location**](Location.md) | Location information | [optional] 
**Price** | [**Price**](Price.md) | Price range information | [optional] 
**Rating** | [**Rating**](Rating.md) | Rating range information | [optional] 
**GroupOfModule** | **string** | Group of module information (taxi|accomodation|train|flight|bus|tourism|all|car_sharing|bike_sharing|train_station_elevator|train_station_parking|car_rental|restaurant|coworkingspace|public_transport) | 
**AccessKey** | **string** | Google Custom Search Engine Access Key | [optional] 
**Providers** | **List&lt;string&gt;** | Search engines selected to search for (If none is selected, then the Service Discovery will search on all search engines) | [optional] 
**ServiceType** | [**DiscoveryRequestServiceType**](DiscoveryRequestServiceType.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

