# UnityBestHttp2Client.Model.WgStateEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**wgId** | [**String**](string.md) | Wargame ID | [default to null]
**phase** | [**Integer**](integer.md) | Phase number for this state | [optional] [default to null]
**updated** | [**Date**](DateTime.md) | Last update of the state | [optional] [default to null]
**gameOver** | [**Boolean**](boolean.md) | Is the wargame over ? | [optional] [default to null]
**territoryStates** | [**Map**](WgTerritoryStateModel.md) | Fixed Territory states of the phase by label | [default to null]
**playerStates** | [**Map**](WgPlayerStateModel.md) | Player states of the phase | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

