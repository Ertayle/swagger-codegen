# UnityBestHttp2Client.Model.MapEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | [**String**](string.md) |  | [default to null]
**mapName** | [**String**](string.md) | Map type name | [default to null]
**version** | [**String**](string.md) | Version string of the Map to handle multiple versions of Maps during games | [default to default]
**startingCurrencies** | [**Map**](integer.md) | Dictionnary of startig currencies | [default to null]
**initialTerritoryStates** | [**Map**](WgTerritoryStateModel.md) | Initial States of all Territories of the Map | [default to null]
**strategicStates** | [**List**](string.md) | List of Strategic states for this Map | [default to null]
**hqs** | [**List**](string.md) | List of HQ for this Map. Attached to the Users by order in the list       corresponding to WgModel objects | [default to null]
**routes** | [**Map**](array.md) | List of Map routes. This field is an oriented graph | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

