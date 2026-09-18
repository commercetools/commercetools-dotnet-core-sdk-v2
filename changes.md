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

- added type `GraphQLAgentBusinessUnitAmbiguousError`
- added type `GraphQLAgentBusinessUnitLimitExceededError`
- added type `GraphQLAgentBusinessUnitUnresolvedError`
- added type `GraphQLAgentExtractionFailedError`
- added type `GraphQLAgentFeatureDisabledError`
- added type `GraphQLAgentMissingCountryError`
- added type `GraphQLAgentMissingCustomerEmailError`
- added type `GraphQLAgentMissingEntityTypeError`
- added type `GraphQLAgentNoLineItemsExtractedError`
- added type `GraphQLAgentOutOfScopeError`
- added type `GraphQLAgentProductSearchNotEnabledError`
- added type `GraphQLAgentProductsNotFoundError`
- added type `GraphQLAgentQuoteRequestCreationFailedError`
- added type `GraphQLAgentStoreAmbiguousError`
- added type `GraphQLAgentStoreDistributionChannelsUnsupportedError`
- added type `GraphQLAgentStoreUnresolvedError`
- added type `CartSetDirectDiscountsIgnoreCartDiscountsAction`
- added type `ExtensionCircularDependencyError`
- added type `GraphQLExtensionCircularDependencyError`
- added type `StagedOrderSetDirectDiscountsIgnoreCartDiscountsAction`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `directDiscountsIgnoreCartDiscounts` to type `Cart`
- added property `directDiscountsIgnoreCartDiscounts` to type `CartDraft`
- added property `participateInBestDealSelection` to type `DirectDiscount`
- added property `participateInBestDealSelection` to type `DirectDiscountDraft`
- added property `directDiscountsIgnoreCartDiscounts` to type `StagedOrder`
- added property `directDiscountsIgnoreCartDiscounts` to type `Order`
- added property `directDiscountsIgnoreCartDiscounts` to type `QuoteRequest`
- added property `directDiscountsIgnoreCartDiscounts` to type `Quote`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `mcp-server` to type `ReferenceTypeId`
- added enum `InMigration` to type `ProductCatalogModel`
</details>

