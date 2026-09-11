**Api changes**

<details>
<summary>MarkDeprecated Type(s)</summary>

- :warning: removed deprecation mark from type `FacetRange`
- :warning: removed deprecation mark from type `FacetResult`
- :warning: removed deprecation mark from type `FacetResults`
- :warning: removed deprecation mark from type `FacetTerm`
- :warning: removed deprecation mark from type `FacetTypes`
- :warning: removed deprecation mark from type `FilteredFacetResult`
- :warning: removed deprecation mark from type `ProductProjectionPagedSearchResponse`
- :warning: removed deprecation mark from type `RangeFacetResult`
- :warning: removed deprecation mark from type `Suggestion`
- :warning: removed deprecation mark from type `SuggestionResult`
- :warning: removed deprecation mark from type `TermFacetResult`
- :warning: removed deprecation mark from type `TermFacetResultType`
</details>


<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `TypeRemoveEnumValuesAction`
- :warning: removed type `TypeRemoveLocalizedEnumValuesAction`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `Expansion`
- added type `QueryPredicate`
- added type `Sort`
</details>


<details>
<summary>MarkDeprecated Property(s)</summary>

- :warning: removed deprecation mark from property `FacetResult::type`
- :warning: removed deprecation mark from property `FacetResults::/^[a-z].*$/`
- :warning: removed deprecation mark from property `FilteredFacetResult::type`
- :warning: removed deprecation mark from property `ProductProjectionPagedSearchResponse::facets`
- :warning: removed deprecation mark from property `RangeFacetResult::type`
- :warning: removed deprecation mark from property `TermFacetResult::type`
- :warning: removed deprecation mark from property `TermFacetResult::dataType`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `productId` to type `VariantCreatedMessage`
- added property `productId` to type `VariantCreatedMessagePayload`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `expand` of type `ProductSearchProjectionParams` from type `string[]` to `Expansion[]`
</details>


<details>
<summary>Removed Property(s)</summary>

- :warning: removed property `product` from type `VariantCreatedMessage`
- :warning: removed property `product` from type `VariantDeletedMessage`
- :warning: removed property `product` from type `VariantImageAddedMessage`
- :warning: removed property `product` from type `VariantImagesSetMessage`
- :warning: removed property `product` from type `VariantKeySetMessage`
- :warning: removed property `product` from type `VariantPublishedMessage`
- :warning: removed property `product` from type `VariantSkuSetMessage`
- :warning: removed property `product` from type `VariantStagedChangesRemovedMessage`
- :warning: removed property `product` from type `VariantCreatedMessagePayload`
- :warning: removed property `product` from type `VariantDeletedMessagePayload`
- :warning: removed property `product` from type `VariantImageAddedMessagePayload`
- :warning: removed property `product` from type `VariantImagesSetMessagePayload`
- :warning: removed property `product` from type `VariantKeySetMessagePayload`
- :warning: removed property `product` from type `VariantPublishedMessagePayload`
- :warning: removed property `product` from type `VariantSkuSetMessagePayload`
- :warning: removed property `product` from type `VariantStagedChangesRemovedMessagePayload`
- :warning: removed property `taxedPrice` from type `CustomLineItemImportDraft`
- :warning: removed property `taxedPrice` from type `LineItemImportDraft`
- :warning: removed property `taxedPrice` from type `ShippingInfoImportDraft`
</details>


<details>
<summary>Removed Enum(s)</summary>

- :warning: removed enum `variant` from type `ChangeSubscriptionResourceTypeId`
- :warning: removed enum `variant` from type `MessageSubscriptionResourceTypeId`
</details>


<details>
<summary>MarkDeprecated Method(s)</summary>

- :warning: removed deprecation mark from method `post /{projectKey}/product-projections/search`
- :warning: removed deprecation mark from method `get /{projectKey}/product-projections/search`
- :warning: removed deprecation mark from method `get /{projectKey}/product-projections/suggest`
</details>

