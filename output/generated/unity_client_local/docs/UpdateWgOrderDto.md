# UnityBestHttp2Client.Model.UpdateWgOrderDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**wgId** | [**String**](string.md) | Wargame id | [optional] [default to null]
**phase** | [**Integer**](integer.md) | Phase number for this order | [optional] [default to null]
**orderId** | [**String**](string.md) | Order consistant id | [optional] [default to null]
**id** | [**String**](string.md) | Order unique id | [optional] [default to null]
**status** | [**OrderStatus**](OrderStatus.md) |  | [optional] [default to null]
**type** | [**OrderType**](OrderType.md) |  | [optional] [default to null]
**userId** | [**String**](string.md) | UserId of the order initiator | [optional] [default to null]
**playerIndex** | [**Integer**](integer.md) | PlayerIndex of the order initiator | [optional] [default to null]
**cancelable** | [**Boolean**](boolean.md) | Can the user cancel the order ? | [optional] [default to null]
**startPhase** | [**Integer**](integer.md) | Phase where the order was created | [optional] [default to null]
**resolutionPhase** | [**Integer**](integer.md) | Phase where the order will be resolved and closed | [optional] [default to null]
**reportProperties** | [**Map**](string.md) | Properties of the report to display when order has been executed | [optional] [default to null]
**originTerritory** | [**String**](string.md) | Starting or origin territory label | [optional] [default to null]
**targetTerritory** | [**String**](string.md) | Target territory label | [optional] [default to null]
**targetOrderId** | [**String**](string.md) | Target Order consistant id | [optional] [default to null]
**currentTerritory** | [**String**](string.md) | Current territory label | [optional] [default to null]
**troops** | [**Map**](integer.md) | Troops engaged in the Order | [optional] [default to null]
**ressources** | [**Map**](integer.md) | Ressources engaged in the order | [optional] [default to null]
**slot** | [**Integer**](integer.md) | Slot index | [optional] [default to null]
**infraType** | [**InfraType**](InfraType.md) |  | [optional] [default to null]
**constructionType** | [**ConstructionType**](ConstructionType.md) |  | [optional] [default to null]
**attackTargetType** | [**AttackTargetType**](AttackTargetType.md) |  | [optional] [default to null]
**constructionAmount** | [**Integer**](integer.md) | Number of constructions to build/destroy | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

