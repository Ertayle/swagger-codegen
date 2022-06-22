# UnityBestHttp2Client.Model.WgEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | [**String**](string.md) | Wargame ID | [default to null]
**planetName** | [**String**](string.md) | Name of the Planet for this WG | [default to null]
**mapName** | [**String**](string.md) | Name of the Map | [default to null]
**mapVersion** | [**String**](string.md) | Version of the Map | [default to null]
**seed** | [**String**](string.md) | Wargame seed | [default to null]
**createdAt** | [**Date**](DateTime.md) | Creation date | [optional] [default to null]
**updatedAt** | [**Date**](DateTime.md) | Update date | [optional] [default to null]
**startedAt** | [**Date**](DateTime.md) | Start date of the Wargame | [optional] [default to null]
**currentPhase** | [**Integer**](integer.md) | Current WG Phase | [default to null]
**users** | [**List**](UserWargameInfoDTO.md) | Stores all Users that initially took part to the     Wargame. If user is dead, it can only be known by     checking the WgStateModel, thus it is recommanded     to add an ingame marker to the User to handle the     information if a WG is on, or not for a User | [default to null]
**overrideParameters** | [**WgParameters**](WgParameters.md) |  | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

