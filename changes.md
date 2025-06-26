**Api changes**

<details>
<summary>Added Type(s)</summary>

- added type `CartDiscountSetDiscountGroupAction`
- added type `DiscountGroup`
- added type `DiscountGroupDraft`
- added type `DiscountGroupPagedQueryResponse`
- added type `DiscountGroupReference`
- added type `DiscountGroupResourceIdentifier`
- added type `DiscountGroupUpdate`
- added type `DiscountGroupUpdateAction`
- added type `DiscountGroupSetDescriptionAction`
- added type `DiscountGroupSetKeyAction`
- added type `DiscountGroupSetNameAction`
- added type `DiscountGroupSetSortOrderAction`
- added type `ExpiredCustomerEmailTokenError`
- added type `ExpiredCustomerPasswordTokenError`
- added type `GraphQLExpiredCustomerEmailTokenError`
- added type `GraphQLExpiredCustomerPasswordTokenError`
- added type `CheckoutOrderCreationFailedEvent`
- added type `CheckoutPaymentAuthorizationCancelledEvent`
- added type `CheckoutPaymentAuthorizationFailedEvent`
- added type `CheckoutPaymentAuthorizedEvent`
- added type `CheckoutPaymentCancelAuthorizationFailedEvent`
- added type `CheckoutPaymentChargeFailedEvent`
- added type `CheckoutPaymentChargedEvent`
- added type `CheckoutPaymentRefundFailedEvent`
- added type `CheckoutPaymentRefundedEvent`
- added type `CheckoutMessageOrderPayloadBaseData`
- added type `CheckoutMessagePaymentsPayloadBaseData`
- added type `DiscountGroupCreatedMessage`
- added type `DiscountGroupDeletedMessage`
- added type `DiscountGroupKeySetMessage`
- added type `DiscountGroupSortOrderSetMessage`
- added type `DiscountGroupCreatedMessagePayload`
- added type `DiscountGroupDeletedMessagePayload`
- added type `DiscountGroupKeySetMessagePayload`
- added type `DiscountGroupSortOrderSetMessagePayload`
- added type `ProductTailoringSetProductAttributeAction`
- added type `AttributeLevelEnum`
- added type `ProductSetProductAttributeAction`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/discount-groups`
- added resource `/{projectKey}/discount-groups/key={key}`
- added resource `/{projectKey}/discount-groups/{ID}`
</details>


<details>
<summary>Removed Property(s)</summary>

- :warning: removed property `/[0-9].[0-9]*[1-9]/` from type `CategoryOrderHints`
- :warning: removed property `//` from type `ProductVariantChannelAvailabilityMap`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `filter` of type `SearchSorting` from type `SearchQueryExpression` to `SearchQuery`
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `sortOrder` of type `CartDiscountDraft` to be optional
</details>


<details>
<summary>Added Property(s)</summary>

- added property `discountGroup` to type `CartDiscount`
- added property `discountGroup` to type `CartDiscountDraft`
- added property `invalidateOlderTokens` to type `CustomerCreateEmailToken`
- added property `invalidateOlderTokens` to type `CustomerCreatePasswordResetToken`
- added property `invalidateOlderTokens` to type `CustomerToken`
- added property `value` to type `CustomerEmailTokenCreatedMessage`
- added property `invalidateOlderTokens` to type `CustomerEmailTokenCreatedMessage`
- added property `value` to type `CustomerPasswordTokenCreatedMessage`
- added property `invalidateOlderTokens` to type `CustomerPasswordTokenCreatedMessage`
- added property `attributes` to type `ProductTailoringCreatedMessage`
- added property `value` to type `CustomerEmailTokenCreatedMessagePayload`
- added property `invalidateOlderTokens` to type `CustomerEmailTokenCreatedMessagePayload`
- added property `value` to type `CustomerPasswordTokenCreatedMessagePayload`
- added property `invalidateOlderTokens` to type `CustomerPasswordTokenCreatedMessagePayload`
- added property `attributes` to type `ProductTailoringCreatedMessagePayload`
- added property `attributes` to type `ProductTailoringData`
- added property `attributes` to type `ProductTailoringDraft`
- added property `attributes` to type `ProductTailoringInStoreDraft`
- added property `level` to type `AttributeDefinition`
- added property `level` to type `AttributeDefinitionDraft`
- added property `/^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$/` to type `CategoryOrderHints`
- added property `attributes` to type `ProductData`
- added property `attributes` to type `ProductDraft`
- added property `attributes` to type `ProductProjection`
- added property `/^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$/` to type `ProductVariantChannelAvailabilityMap`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().discountGroups().get()`
- added method `apiRoot.withProjectKey().discountGroups().head()`
- added method `apiRoot.withProjectKey().discountGroups().post()`
- added method `apiRoot.withProjectKey().discountGroups().withKey().get()`
- added method `apiRoot.withProjectKey().discountGroups().withKey().head()`
- added method `apiRoot.withProjectKey().discountGroups().withKey().post()`
- added method `apiRoot.withProjectKey().discountGroups().withKey().delete()`
- added method `apiRoot.withProjectKey().discountGroups().withId().get()`
- added method `apiRoot.withProjectKey().discountGroups().withId().head()`
- added method `apiRoot.withProjectKey().discountGroups().withId().post()`
- added method `apiRoot.withProjectKey().discountGroups().withId().delete()`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `ApplicationStoppedByGroupBestDeal` to type `DiscountCodeState`
- added enum `discount-group` to type `ReferenceTypeId`
- added enum `checkout` to type `EventSubscriptionResourceTypeId`
- added enum `CheckoutOrderCreationFailed` to type `EventType`
- added enum `CheckoutPaymentAuthorizationCancelled` to type `EventType`
- added enum `CheckoutPaymentAuthorizationFailed` to type `EventType`
- added enum `CheckoutPaymentAuthorized` to type `EventType`
- added enum `CheckoutPaymentCancelAuthorizationFailed` to type `EventType`
- added enum `CheckoutPaymentCharged` to type `EventType`
- added enum `CheckoutPaymentChargeFailed` to type `EventType`
- added enum `CheckoutPaymentRefunded` to type `EventType`
- added enum `CheckoutPaymentRefundFailed` to type `EventType`
</details>

**Import changes**

<details>
<summary>Added Type(s)</summary>

- added type `AttributeLevel`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `attributes` to type `ProductImport`
- added property `attributes` to type `ProductDraftImport`
- added property `level` to type `AttributeDefinition`
</details>

**History changes**

<details>
<summary>Added Enum(s)</summary>

- added enum `ApplicationStoppedByGroupBestDeal` to type `DiscountCodeState`
</details>

