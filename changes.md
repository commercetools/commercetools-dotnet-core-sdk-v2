**Api changes**

<details>
<summary>Required Property(s)</summary>

- changed property `isOnStock` of type `ProductVariantAvailability` to be optional
</details>


<details>
<summary>Added Property(s)</summary>

- added property `approvalRuleMode` to type `BusinessUnit`
- added property `approvalRuleMode` to type `BusinessUnitDraft`
- added property `approvalRuleMode` to type `Company`
- added property `approvalRuleMode` to type `CompanyDraft`
- added property `approvalRuleMode` to type `Division`
- added property `approvalRuleMode` to type `DivisionDraft`
- added property `metaTitle` to type `ProductTailoringCreatedMessage`
- added property `metaDescription` to type `ProductTailoringCreatedMessage`
- added property `metaKeywords` to type `ProductTailoringCreatedMessage`
- added property `variants` to type `ProductTailoringCreatedMessage`
- added property `metaTitle` to type `ProductTailoringCreatedMessagePayload`
- added property `metaDescription` to type `ProductTailoringCreatedMessagePayload`
- added property `metaKeywords` to type `ProductTailoringCreatedMessagePayload`
- added property `variants` to type `ProductTailoringCreatedMessagePayload`
- added property `variants` to type `ProductTailoringData`
- added property `variants` to type `ProductTailoringDraft`
- added property `variants` to type `ProductTailoringInStoreDraft`
- added property `store` to type `StagedQuote`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `totalPrice` of type `OrderLineItemDiscountSetMessage` from type `Money` to `CentPrecisionMoney`
- :warning: changed property `value` of type `StandalonePriceValueChangedMessage` from type `Money` to `TypedMoney`
- :warning: changed property `oldValue` of type `StandalonePriceValueChangedMessage` from type `Money` to `TypedMoney`
- :warning: changed property `totalPrice` of type `OrderLineItemDiscountSetMessagePayload` from type `Money` to `CentPrecisionMoney`
- :warning: changed property `value` of type `StandalonePriceValueChangedMessagePayload` from type `Money` to `TypedMoney`
- :warning: changed property `oldValue` of type `StandalonePriceValueChangedMessagePayload` from type `Money` to `TypedMoney`
- :warning: changed property `price` of type `ShippingRate` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `freeAbove` of type `ShippingRate` from type `TypedMoney` to `CentPrecisionMoney`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `attribute-group` to type `ChangeSubscriptionResourceTypeId`
- added enum `product-tailoring` to type `ChangeSubscriptionResourceTypeId`
</details>


<details>
<summary>Removed Enum(s)</summary>

- :warning: removed enum `product-price` from type `ChangeSubscriptionResourceTypeId`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().customers().search().post()`
- added method `apiRoot.withProjectKey().customers().search().head()`
- added method `apiRoot.withProjectKey().customers().searchIndexingStatus().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().orders().orderQuote().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().products().withProductId().productTailoring().images().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().products().withProductKey().productTailoring().images().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().withKey().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().withKey().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().withKey().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().withId().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().withId().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quoteRequests().withId().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().withKey().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().withKey().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().withKey().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().withId().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().withId().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().stagedQuotes().withId().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().withKey().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().withKey().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().withKey().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().withId().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().withId().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().quotes().withId().delete()`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `BusinessUnitApprovalRuleMode`
- added type `BusinessUnitChangeApprovalRuleModeAction`
- added type `CustomerIndexingProgress`
- added type `CustomerIndexingStatus`
- added type `CustomerPagedSearchResponse`
- added type `CustomerSearchIndexingStatusResponse`
- added type `CustomerSearchRequest`
- added type `CustomerSearchResult`
- added type `BusinessUnitApprovalRuleModeChangedMessage`
- added type `ProductPriceCustomFieldAddedMessage`
- added type `ProductPriceCustomFieldChangedMessage`
- added type `ProductPriceCustomFieldRemovedMessage`
- added type `ProductPriceCustomFieldsRemovedMessage`
- added type `ProductPriceCustomFieldsSetMessage`
- added type `ProductTailoringImageAddedMessage`
- added type `ProductTailoringImagesSetMessage`
- added type `ProductVariantTailoringAddedMessage`
- added type `ProductVariantTailoringRemovedMessage`
- added type `BusinessUnitApprovalRuleModeChangedMessagePayload`
- added type `ProductPriceCustomFieldAddedMessagePayload`
- added type `ProductPriceCustomFieldChangedMessagePayload`
- added type `ProductPriceCustomFieldRemovedMessagePayload`
- added type `ProductPriceCustomFieldsRemovedMessagePayload`
- added type `ProductPriceCustomFieldsSetMessagePayload`
- added type `ProductTailoringImageAddedMessagePayload`
- added type `ProductTailoringImagesSetMessagePayload`
- added type `ProductVariantTailoringAddedMessagePayload`
- added type `ProductVariantTailoringRemovedMessagePayload`
- added type `ProductVariantTailoring`
- added type `ProductVariantTailoringDraft`
- added type `ProductTailoringAddAssetAction`
- added type `ProductTailoringAddExternalImageAction`
- added type `ProductTailoringAddVariantAction`
- added type `ProductTailoringChangeAssetNameAction`
- added type `ProductTailoringChangeAssetOrderAction`
- added type `ProductTailoringMoveImageToPositionAction`
- added type `ProductTailoringRemoveAssetAction`
- added type `ProductTailoringRemoveImageAction`
- added type `ProductTailoringRemoveVariantAction`
- added type `ProductTailoringSetAssetCustomFieldAction`
- added type `ProductTailoringSetAssetCustomTypeAction`
- added type `ProductTailoringSetAssetDescriptionAction`
- added type `ProductTailoringSetAssetKeyAction`
- added type `ProductTailoringSetAssetSourcesAction`
- added type `ProductTailoringSetAssetTagsAction`
- added type `ProductTailoringSetExternalImagesAction`
- added type `ProductTailoringSetImageLabelAction`
- added type `CustomerSearchStatus`
- added type `ProjectChangeCustomerSearchStatusAction`
</details>


<details>
<summary>Removed QueryParameter(s)</summary>

- :warning: removed query parameter `localeProjection` from method `get /{projectKey}/products`
- :warning: removed query parameter `localeProjection` from method `post /{projectKey}/products`
- :warning: removed query parameter `localeProjection` from method `get /{projectKey}/products/key={key}`
- :warning: removed query parameter `localeProjection` from method `post /{projectKey}/products/key={key}`
- :warning: removed query parameter `localeProjection` from method `delete /{projectKey}/products/key={key}`
- :warning: removed query parameter `localeProjection` from method `get /{projectKey}/products/{ID}`
- :warning: removed query parameter `localeProjection` from method `post /{projectKey}/products/{ID}`
- :warning: removed query parameter `localeProjection` from method `delete /{projectKey}/products/{ID}`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/customers/search`
- added resource `/{projectKey}/customers/search/indexing-status`
- added resource `/{projectKey}/in-store/key={storeKey}/quote-requests`
- added resource `/{projectKey}/in-store/key={storeKey}/staged-quotes`
- added resource `/{projectKey}/in-store/key={storeKey}/quotes`
- added resource `/{projectKey}/in-store/key={storeKey}/orders/quotes`
- added resource `/{projectKey}/in-store/key={storeKey}/products/{productID}/product-tailoring/images`
- added resource `/{projectKey}/in-store/key={storeKey}/products/key={productKey}/product-tailoring/images`
- added resource `/{projectKey}/in-store/key={storeKey}/quote-requests/key={key}`
- added resource `/{projectKey}/in-store/key={storeKey}/quote-requests/{ID}`
- added resource `/{projectKey}/in-store/key={storeKey}/staged-quotes/key={key}`
- added resource `/{projectKey}/in-store/key={storeKey}/staged-quotes/{ID}`
- added resource `/{projectKey}/in-store/key={storeKey}/quotes/key={key}`
- added resource `/{projectKey}/in-store/key={storeKey}/quotes/{ID}`
</details>

