**Api changes**

<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `CircularDependencyError`
- :warning: removed type `MissingDependencyError`
- :warning: removed type `GraphQLCircularDependencyError`
- :warning: removed type `GraphQLMissingDependencyError`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `AgentMissingShoppingListNameError`
- added type `AgentResponsesShoppingListSuccess`
- added type `AgentShoppingListCreationFailedError`
- added type `GraphQLAgentBusinessUnitAmbiguousError`
- added type `GraphQLAgentBusinessUnitLimitExceededError`
- added type `GraphQLAgentBusinessUnitUnresolvedError`
- added type `GraphQLAgentExtractionFailedError`
- added type `GraphQLAgentFeatureDisabledError`
- added type `GraphQLAgentMissingCountryError`
- added type `GraphQLAgentMissingCustomerEmailError`
- added type `GraphQLAgentMissingEntityTypeError`
- added type `GraphQLAgentMissingShoppingListNameError`
- added type `GraphQLAgentNoLineItemsExtractedError`
- added type `GraphQLAgentOutOfScopeError`
- added type `GraphQLAgentProductSearchNotEnabledError`
- added type `GraphQLAgentProductsNotFoundError`
- added type `GraphQLAgentQuoteRequestCreationFailedError`
- added type `GraphQLAgentShoppingListCreationFailedError`
- added type `GraphQLAgentStoreAmbiguousError`
- added type `GraphQLAgentStoreDistributionChannelsUnsupportedError`
- added type `GraphQLAgentStoreUnresolvedError`
- added type `CartSetDirectDiscountsIgnoreCartDiscountsAction`
- added type `CategoryAddStoreAction`
- added type `CategoryRemoveStoreAction`
- added type `CategorySetStoresAction`
- added type `ExtensionCircularDependencyError`
- added type `GraphQLExtensionCircularDependencyError`
- added type `StagedOrderSetDirectDiscountsIgnoreCartDiscountsAction`
- added type `ProductTypeChangeSavedToLineItemAction`
- added type `TaxRoundingTarget`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `directDiscountsIgnoreCartDiscounts` to type `Cart`
- added property `directDiscountsIgnoreCartDiscounts` to type `CartDraft`
- added property `participateInBestDealSelection` to type `DirectDiscount`
- added property `participateInBestDealSelection` to type `DirectDiscountDraft`
- added property `taxRoundingTarget` to type `ExternalTaxRateDraft`
- added property `stores` to type `Category`
- added property `stores` to type `CategoryDraft`
- added property `directDiscountsIgnoreCartDiscounts` to type `StagedOrder`
- added property `directDiscountsIgnoreCartDiscounts` to type `Order`
- added property `savedToLineItem` to type `AttributeDefinition`
- added property `savedToLineItem` to type `AttributeDefinitionDraft`
- added property `directDiscountsIgnoreCartDiscounts` to type `QuoteRequest`
- added property `directDiscountsIgnoreCartDiscounts` to type `Quote`
- added property `taxRoundingTarget` to type `TaxRate`
- added property `taxRoundingTarget` to type `TaxRateDraft`
- added property `restockableInDays` to type `VariantAttributesAvailability`
- added property `restockableInDays` to type `VariantAttributesChannelAvailability`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/in-store/key={storeKey}/categories`
- added resource `/{projectKey}/in-store/key={storeKey}/categories/key={key}`
- added resource `/{projectKey}/in-store/key={storeKey}/categories/{ID}`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `ShoppingList` to type `AgentResponsesOutputType`
- added enum `IntakeAgent` to type `AttributionSource`
- added enum `PromotionsAgent` to type `AttributionSource`
- added enum `ManagedCommerceMCP` to type `AttributionSource`
- added enum `mcp-server` to type `ReferenceTypeId`
- added enum `product` to type `ExtensionResourceTypeId`
- added enum `InMigration` to type `ProductCatalogModel`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().withKey().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().withKey().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().withKey().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().withId().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().withId().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().categories().withId().delete()`
</details>

**History changes**

<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `userIds` to method `get /{projectKey}`
- added query parameter `resourceIds` to method `get /{projectKey}`
- added query parameter `userIds` to method `get /{projectKey}/{resourceType}`
- added query parameter `resourceIds` to method `get /{projectKey}/{resourceType}`
- added query parameter `userIds` to method `get /{projectKey}/{resourceType}/{ID}`
</details>

