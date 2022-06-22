# UnityBestHttp2Client.Model.WgTerritoryStateModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ownerIndex** | [**Integer**](integer.md) | Optional player index of owner of the territory, empty if neutral | [optional] [default to null]
**slots** | [**Integer**](integer.md) | Number of infrastructure slots | [default to null]
**population** | [**Integer**](integer.md) | Total territory population | [default to null]
**availablePop** | [**Integer**](integer.md) | Current available territory population | [default to null]
**fortifyStatus** | [**FortifyStatus**](FortifyStatus.md) |  | [default to null]
**ressources** | [**Map**](integer.md) | List of all ressources | [default to null]
**mines** | [**Map**](integer.md) | List of all mines and their population | [optional] [default to null]
**infraStates** | [**Map**](WgInfraStateModel.md) | Map of all infraStates by slotID | [default to null]
**consAmount** | [**Map**](integer.md) | Map of constructions amount by ConstructionType | [default to null]
**troopStates** | [**Map**](map.md) | Troop state of the territory by playerIndex | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

