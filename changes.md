**Api changes**

<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `exact` of type `SearchExactExpression` from type `SearchAnyValue` to `SearchExactValue`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `applicationMode` to type `CartDiscountValueFixed`
- added property `applicationMode` to type `CartDiscountValueFixedDraft`
- added property `custom` to type `CartSetCustomShippingMethodAction`
- added property `customerGroupAssignments` to type `Customer`
- added property `customerGroupAssignments` to type `CustomerDraft`
- added property `custom` to type `StagedOrderSetCustomShippingMethodAction`
- added property `custom` to type `StagedOrderSetShippingAddressAndCustomShippingMethodAction`
- added property `priceCustomerGroupAssignments` to type `ProductSearchProjectionParams`
- added property `businessUnits` to type `SearchIndexingConfiguration`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/business-units/search`
- added resource `/{projectKey}/business-units/search/indexing-status`
- added resource `/{projectKey}/channels/key={key}`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().businessUnits().search().post()`
- added method `apiRoot.withProjectKey().businessUnits().search().head()`
- added method `apiRoot.withProjectKey().businessUnits().searchIndexingStatus().get()`
- added method `apiRoot.withProjectKey().channels().withKey().get()`
- added method `apiRoot.withProjectKey().channels().withKey().head()`
- added method `apiRoot.withProjectKey().channels().withKey().post()`
- added method `apiRoot.withProjectKey().channels().withKey().delete()`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `BusinessUnitIndexingProgress`
- added type `BusinessUnitIndexingStatus`
- added type `BusinessUnitPagedSearchResponse`
- added type `BusinessUnitSearchIndexingStatusResponse`
- added type `BusinessUnitSearchRequest`
- added type `BusinessUnitSearchResult`
- added type `CartDiscountPatternTarget`
- added type `CountOnCustomLineItemUnits`
- added type `CountOnLineItemUnits`
- added type `PatternComponent`
- added type `CustomerGroupAssignment`
- added type `CustomerGroupAssignmentDraft`
- added type `CustomerAddCustomerGroupAssignmentAction`
- added type `CustomerRemoveCustomerGroupAssignmentAction`
- added type `CustomerSetCustomerGroupAssignmentsAction`
- added type `CustomerGroupAssignmentAddedMessage`
- added type `CustomerGroupAssignmentRemovedMessage`
- added type `CustomerGroupAssignmentsSetMessage`
- added type `ShoppingListLineItemAddedMessage`
- added type `ShoppingListLineItemRemovedMessage`
- added type `ShoppingListMessage`
- added type `CustomerGroupAssignmentAddedMessagePayload`
- added type `CustomerGroupAssignmentRemovedMessagePayload`
- added type `CustomerGroupAssignmentsSetMessagePayload`
- added type `ShoppingListLineItemAddedMessagePayload`
- added type `ShoppingListLineItemRemovedMessagePayload`
- added type `ShoppingListMessagePayload`
- added type `BusinessUnitSearchStatus`
- added type `ProjectChangeBusinessUnitSearchStatusAction`
- added type `SearchExactValue`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `Canceled` to type `ShipmentState`
- added enum `shopping-list` to type `MessageSubscriptionResourceTypeId`
</details>


<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `priceCustomerGroupAssignments` to method `get /{projectKey}/products`
- added query parameter `priceCustomerGroupAssignments` to method `post /{projectKey}/products`
- added query parameter `priceCustomerGroupAssignments` to method `get /{projectKey}/product-projections`
- added query parameter `priceCustomerGroupAssignments` to method `get /{projectKey}/products/key={key}`
- added query parameter `priceCustomerGroupAssignments` to method `post /{projectKey}/products/key={key}`
- added query parameter `priceCustomerGroupAssignments` to method `delete /{projectKey}/products/key={key}`
- added query parameter `priceCustomerGroupAssignments` to method `get /{projectKey}/products/{ID}`
- added query parameter `priceCustomerGroupAssignments` to method `post /{projectKey}/products/{ID}`
- added query parameter `priceCustomerGroupAssignments` to method `delete /{projectKey}/products/{ID}`
- added query parameter `priceCustomerGroupAssignments` to method `get /{projectKey}/product-projections/search`
- added query parameter `priceCustomerGroupAssignments` to method `get /{projectKey}/product-projections/key={key}`
- added query parameter `priceCustomerGroupAssignments` to method `get /{projectKey}/product-projections/{ID}`
- added query parameter `priceCustomerGroupAssignments` to method `get /{projectKey}/in-store/key={storeKey}/product-projections/key={key}`
- added query parameter `priceCustomerGroupAssignments` to method `get /{projectKey}/in-store/key={storeKey}/product-projections/{ID}`
</details>

**Import changes**

<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `ReferencedResourceNotFound`
</details>

**History changes**

<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/graphql`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKeyValue().graphql().post()`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `GraphQLRequest`
- added type `GraphQLResponse`
- added type `GraphQLError`
- added type `GraphQLErrorLocation`
- added type `GraphQLVariablesMap`
- added type `ChangeTargetPatternChangeValue`
- added type `PatternComponent`
</details>

