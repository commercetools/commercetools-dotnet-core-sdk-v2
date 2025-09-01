
# 13.1.0 (2025-09-01)

**Api changes**

<details>
<summary>Added Property(s)</summary>

- added property `isActive` to type `DiscountGroup`
- added property `isActive` to type `DiscountGroupDraft`
- added property `minCartQuantity` to type `InventoryEntry`
- added property `maxCartQuantity` to type `InventoryEntry`
- added property `minCartQuantity` to type `InventoryEntryDraft`
- added property `maxCartQuantity` to type `InventoryEntryDraft`
- added property `expiresAt` to type `RecurringOrderDraft`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `DiscountGroupSetIsActiveAction`
- added type `MaxDiscountGroupsReachedError`
- added type `GraphQLMaxDiscountGroupsReachedError`
- added type `InventoryEntrySetInventoryLimitsAction`
- added type `CustomerDefaultBillingAddressSetMessage`
- added type `CustomerDefaultShippingAddressSetMessage`
- added type `CustomerStoresSetMessage`
- added type `DiscountGroupIsActiveSetMessage`
- added type `RecurringOrderExpiresAtSetMessage`
- added type `CustomerDefaultBillingAddressSetMessagePayload`
- added type `CustomerDefaultShippingAddressSetMessagePayload`
- added type `CustomerStoresSetMessagePayload`
- added type `DiscountGroupIsActiveSetMessagePayload`
- added type `RecurringOrderExpiresAtSetMessagePayload`
- added type `RecurringOrderSetExpiresAtAction`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().recurrencePolicies().withKey().delete()`
- added method `apiRoot.withProjectKey().recurrencePolicies().withId().delete()`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `discount-group` to type `ChangeSubscriptionResourceTypeId`
</details>

**Import changes**

<details>
<summary>Added Type(s)</summary>

- added type `AssociateRoleKeyReference`
- added type `BusinessUnitKeyReference`
- added type `BusinessUnitImportRequest`
- added type `AssociateRoleInheritanceMode`
- added type `BusinessUnitStatus`
- added type `BusinessUnitAssociateMode`
- added type `BusinessUnitApprovalRuleMode`
- added type `BusinessUnitStoreMode`
- added type `BusinessUnitType`
- added type `AssociateRoleAssignmentDraft`
- added type `AssociateDraft`
- added type `BusinessUnitImport`
- added type `CompanyBusinessUnitImport`
- added type `DivisionBusinessUnitImport`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/business-units`
- added resource `/{projectKey}/business-units/import-containers`
- added resource `/{projectKey}/business-units/import-containers/{importContainerKey}`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKeyValue().businessUnits().importContainers().withImportContainerKeyValue().post()`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `business-unit` to type `ImportResourceType`
- added enum `associate-role` to type `ReferenceType`
- added enum `business-unit` to type `ReferenceType`
</details>


## What's Changed
* Update changelog by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/472
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/473
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/474
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/475
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/476
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/478
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/479
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/480
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/481
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/482


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/13.0.0...13.1.0

# 13.0.0 (2025-07-25)

## Breaking Changes

The field `paymentMethodInfo` in type `PaymentDraft` and `MyPaymentDraft` has been changed from `PaymentMethodInfo` to `PaymentMethodInfoDraft`. For `IPaymentMethodInfo` and `ICustomFields` a helper method `ToDraft` has been added.

## New Features

Adds support for [Discount Groups](https://docs.commercetools.com/api/projects/discount-groups) and [Recurring Orders](https://docs.commercetools.com/api/recurring-orders-overview)

Adds support for [product level attributes](https://docs.commercetools.com/api/releases/2025-06-26-added-support-for-attributes-at-the-product-level)

## What's Changed
* Update changelog by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/458
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/459
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/460
* add permissions to GH workflows by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/461
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/462
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/463
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/464
* Add region addresses to Example by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/465
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/466
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/467
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/468
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/469
* Update generated SDKs by @ct-sdks[bot] in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/470


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.13.0...13.0.0

# 12.13.0 (2025-06-03)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/453
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/454
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/455
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/456
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/457

**Import changes**

<details>
<summary>Removed Property(s)</summary>

- :warning: removed property `/^[a-z]{2}(-[A-Z]{2})?$/` from type `SearchKeywords`
- :warning: removed property `/^[a-z]{2}(-[A-Z]{2})?$/` from type `LocalizedString`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `/^[a-zA-Z]{2,3}(?:-[a-zA-Z]{4})?(?:-(?:[a-zA-Z]{2}|\d{3}))?$/` to type `SearchKeywords`
- added property `/^[a-zA-Z]{2,3}(?:-[a-zA-Z]{4})?(?:-(?:[a-zA-Z]{2}|\d{3}))?$/` to type `LocalizedString`
</details>

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.12.0...12.13.0

# 12.12.0 (2025-05-05)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/451
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/452

**Api changes**

<details>
<summary>Added Property(s)</summary>

- added property `published` to type `ShoppingListLineItem`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.11.0...12.12.0

# 12.11.0 (2025-04-29)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/442
* Events sdk fixes by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/443
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/444
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/448
* add instore query methods by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/446
* Fix NPE for AsDecimal extension methods by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/450


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.10.0...12.11.0

# 12.10.0 (2025-04-01)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/429
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/430
* bump system.text.json by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/431
* Create semgrep.yml by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/432
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/433
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/435
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/437
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/439
* add interfaces for ProjectApiRoot by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/440
* Fix serialization of Dates for Import API by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/441

**Api changes**

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


<details>
<summary>Removed QueryParameter(s)</summary>

- :warning: removed query parameter `withTotal` from method `get /{projectKey}/product-projections/search`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `CustomerGroupAssignment`
- added type `CustomerGroupAssignmentDraft`
- added type `CustomerAddCustomerGroupAssignmentAction`
- added type `CustomerRemoveCustomerGroupAssignmentAction`
- added type `CustomerSetCustomerGroupAssignmentsAction`
- added type `CustomerGroupAssignmentAddedMessage`
- added type `CustomerGroupAssignmentRemovedMessage`
- added type `CustomerGroupAssignmentsSetMessage`
- added type `CustomerGroupAssignmentAddedMessagePayload`
- added type `CustomerGroupAssignmentRemovedMessagePayload`
- added type `CustomerGroupAssignmentsSetMessagePayload`
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `facets` of type `ProductProjectionPagedSearchResponse` to be optional
</details>


<details>
<summary>Added Property(s)</summary>

- added property `customerGroupAssignments` to type `Customer`
- added property `customerGroupAssignments` to type `CustomerDraft`
- added property `priceCustomerGroupAssignments` to type `ProductSearchProjectionParams`
</details>

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.9.0...12.10.0

# 12.9.0 (2025-03-17)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/425
* add interface for paged response types by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/427
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/428


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.8.0...12.9.0

# 12.8.0 (2025-03-12)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/414
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/415
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/416
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/417
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/418
* Add constructors to LocalizedString by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/420
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/421
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/423
* update ZeroQL by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/424

**Api changes**

<details>
<summary>Added Enum(s)</summary>

- added enum `ViewMyShoppingLists` to type `Permission`
- added enum `ViewOthersShoppingLists` to type `Permission`
- added enum `UpdateMyShoppingLists` to type `Permission`
- added enum `UpdateOthersShoppingLists` to type `Permission`
- added enum `CreateMyShoppingLists` to type `Permission`
- added enum `CreateOthersShoppingLists` to type `Permission`
- added enum `DeleteMyShoppingLists` to type `Permission`
- added enum `DeleteOthersShoppingLists` to type `Permission`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `BusinessUnitAssociateResponse`
- added type `BestDeal`
- added type `DiscountTypeCombination`
- added type `Stacking`
- added type `OrderBusinessUnitSetMessage`
- added type `OrderBusinessUnitSetMessagePayload`
- added type `StagedOrderSetBusinessUnitAction`
- added type `OrderSetBusinessUnitAction`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/shopping-lists`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/shopping-lists/key={key}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/shopping-lists/{ID}`
- added resource `/{projectKey}/business-units/key={key}/associates/{associateId}`
- added resource `/{projectKey}/business-units/{businessUnitId}/associates/{associateId}`
- added resource `/{projectKey}/in-store/key={storeKey}/business-units/key={key}/associates/{associateId}`
- added resource `/{projectKey}/in-store/key={storeKey}/business-units/{businessUnitId}/associates/{associateId}`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().withKey().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().withKey().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().withKey().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().withKey().delete()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().withId().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().withId().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().withId().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().shoppingLists().withId().delete()`
- added method `apiRoot.withProjectKey().businessUnits().keyWithKeyValueAssociatesWithAssociateIdValue().get()`
- added method `apiRoot.withProjectKey().businessUnits().withBusinessUnitIdValueAssociatesWithAssociateIdValue().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().keyWithKeyValueAssociatesWithAssociateIdValue().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withBusinessUnitIdValueAssociatesWithAssociateIdValue().get()`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `discountTypeCombination` to type `Cart`
- added property `discountTypeCombination` to type `StagedOrder`
- added property `discountTypeCombination` to type `Order`
</details>


<details>
<summary>MarkDeprecated Property(s)</summary>

- marked property `CountOnCustomLineItemUnits::excludeCount` as deprecated
- marked property `CountOnLineItemUnits::excludeCount` as deprecated
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.7.0...12.8.0

# 12.7.0 (2025-02-27)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/408
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/409
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/410
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/411
* [DEVX-551] add json converter for ProductTailoringAttributes by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/413

**History changes**

<details>
<summary>Removed Enum(s)</summary>

- :warning: removed enum `setAsssetKey` from type `UpdateType`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `setAssetKey` to type `UpdateType`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.6.0...12.7.0

# 12.6.0 (2025-02-13)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/404
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/405
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/406
* Make custom fields queryable through DSL by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/407

**Api changes**

<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `AssociateRoleNameChangedMessage`
- :warning: removed type `AssociateRoleNameChangedMessagePayload`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `AssociateRoleNameSetMessage`
- added type `AssociateRoleNameSetMessagePayload`
</details>

### Fixes

The `AssociateRoleNameChangedMessage` has been renamed to `AssociateRoleNameSetMessage` to be consistent with the message `type` value.

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.5.0...12.6.0

# 12.5.0 (2025-02-10)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/400
* feat(api): Option to not fail on head calls by @sommmen in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/396
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/401
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/402
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/403

**Api changes**

<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `ProductSearchFacetScope`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `ShoppingListSetBusinessUnitAction`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `businessUnit` to type `ShoppingList`
- added property `businessUnit` to type `ShoppingListDraft`
</details>

## New Contributors
* @sommmen made their first contribution in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/396

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.4.0...12.5.0

# 12.4.0 (2025-02-03)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/398
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/399


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.3.0...12.4.0

# 12.3.0 (2025-01-28)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/394
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/395
* add custom field helper methods by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/397


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.2.0...12.3.0

# 12.2.0 (2025-01-22)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/384
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/385
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/386
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/387
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/388
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/389
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/390
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/391
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/392
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/393

**Api changes**

<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `discount` of type `DiscountedTotalPricePortion` from type `CartDiscountReference` to `Reference`
- :warning: changed property `exact` of type `SearchExactExpression` from type `SearchAnyValue` to `SearchExactValue`
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `images` of type `ProductTailoringSetExternalImagesAction` to be optional
</details>


<details>
<summary>Added Property(s)</summary>

- added property `inheritedStores` to type `BusinessUnit`
- added property `inheritedStores` to type `Company`
- added property `inheritedStores` to type `Division`
- added property `applicationMode` to type `CartDiscountValueFixed`
- added property `applicationMode` to type `CartDiscountValueFixedDraft`
- added property `custom` to type `CartSetCustomShippingMethodAction`
- added property `custom` to type `StagedOrderSetCustomShippingMethodAction`
- added property `custom` to type `StagedOrderSetShippingAddressAndCustomShippingMethodAction`
- added property `businessUnits` to type `SearchIndexingConfiguration`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/business-units/search`
- added resource `/{projectKey}/business-units/search/indexing-status`
- added resource `/{projectKey}/channels/key={key}`
- added resource `/{projectKey}/in-store/key={storeKey}/business-units`
- added resource `/{projectKey}/in-store/key={storeKey}/business-units/key={key}`
- added resource `/{projectKey}/in-store/key={storeKey}/business-units/{ID}`
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
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withKey().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withKey().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withKey().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withId().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withId().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withId().delete()`
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
- added type `ShoppingListLineItemAddedMessage`
- added type `ShoppingListLineItemRemovedMessage`
- added type `ShoppingListMessage`
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

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.1.0...12.2.0

# 12.1.0 (2024-12-02)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/382
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/383


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/12.0.0...12.1.0

# 12.0.0 (2024-11-26)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/376
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/377
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/378
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/379
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/380
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/381
* Version 12.0.0 preparation by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/360

**Api changes**

<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `line` of type `GraphQLErrorLocation` from type `integer` to `number`
- :warning: changed property `column` of type `GraphQLErrorLocation` from type `integer` to `number`
- :warning: changed property `totalPrice` of type `StagedOrder` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `totalPrice` of type `Order` from type `TypedMoney` to `CentPrecisionMoney`
</details>


<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `where` to method `get /{projectKey}/product-selections/key={key}/products`
- added query parameter `where` to method `get /{projectKey}/product-selections/{ID}/products`
</details>

### New Features

- Improved internal logger
	- the SDKs internal HttpLogger now offers more configuration options like debug/trace logs and different LogLevels
		for specific exception types.
		
		```csharp
	 	services.AddSingleton<ILoggerHandlerOptions>(new LoggerHandlerOptions()
        {
            ResponseLogEvent = LogLevel.Information,
            DefaultExceptionLogEvent = LogLevel.Warning,
            ExceptionLogEvents = new Dictionary<System.Type, LogLevel>()
            {
                { typeof(NotFoundException), LogLevel.Information },
                { typeof(ConcurrentModificationException), LogLevel.Information}
            }
        });
		```
		
- ClientBuilder class
	- the ClientBuilder replaces the ClientFactory. ClientFactory calls internally invoke ClientBuilder methods
		```csharp
		var client = new ClientBuilder {
                        ClientName = clientName,
                        ClientConfiguration = clientConfiguration,
                        HttpClient = serviceProvider.GetService<IHttpClientFactory>().CreateClient(clientName),
                        SerializerService = serializerFactory(serviceProvider),
                        TokenProvider = tokenProviderSupplier(clientName, configuration, serviceProvider),
                        ReadResponseAsStream = options.ReadResponseAsStream,
                        CorrelationIdProvider = serviceProvider.GetService<ICorrelationIdProvider>(),
                        Middlewares = middlewares
                    }.Build();
		```
- [NotFoundMiddleware](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/blob/8f2f9b0fa9ccbbd5b1ed1aefdac764c536c2ba6f/commercetools.Sdk/IntegrationTests/commercetools.Api.IntegrationTests/MiddlewareTest.cs#L25-L28)
	- This middleware allows to return null in case a resource returns a 404 error instead of throwing an exception

		```csharp
		services.UseCommercetoolsApi(configuration, "Client", options: new ClientOptions() { ReadResponseAsStream = true},middlewares: new List<DelegatingMiddleware>()
        {
            new NotFoundMiddleware()
        });
		```

- allow adding custom middlewares to the dependency injection setup

## BREAKING CHANGES

- Updated the target framework to .NET 6.0 [PR #361](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/361)
- HttpVersion is set to 2.0 in the HttpClient instead of the ApiMethod
- Use Streams for response bodies by default [PR #359](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/359) - thanks to @Henr1k80
	- The StreamCtpClient is now used by default which reduces the overall CPU & memory footprint significantly
- Log Format has been changed [PR #273](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/273)
	- The log format has been changed to `{HttpMethod} {Uri} {StatusCode} {Timing} {CorrelationId} {ServerTiming}`. Log scopes aren't used anymore
	- by default only response information is being logged
	- raising the loglevel to debug logs request information
	- raising to loglevel trace logs request and response bodies

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.14.0...12.0.0

# 11.14.0 (2024-11-11)

## What's Changed
* add converter for product search facets by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/375


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.13.0...11.14.0

# 11.13.0 (2024-11-06)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/364
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/365
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/366
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/367
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/368
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/369
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/370
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/371


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.12.0...11.13.0

# 11.12.0 (2024-10-08)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/352
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/353
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/354
* Create config.yml by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/355
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/356
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/357
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/358
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/362
* Update ci.yml by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/363

**Api changes**

<details>
<summary>Added Property(s)</summary>

- added property `staged` to type `ProductVariantDeletedMessage`
- added property `staged` to type `ProductVariantDeletedMessagePayload`
- added property `warnings` to type `ProductTailoring`
- added property `attributes` to type `ProductVariantTailoring`
- added property `attributes` to type `ProductVariantTailoringDraft`
- added property `attributes` to type `ProductTailoringAddVariantAction`
- added property `warnings` to type `Product`
- added property `customers` to type `SearchIndexingConfiguration`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `SearchNotReadyError`
- added type `GraphQLSearchNotReadyError`
- added type `ProductTailoringAttribute`
- added type `ProductTailoringSetAttributeAction`
- added type `ProductTailoringSetAttributeInAllVariantsAction`
- added type `ImageProcessingOngoingWarning`
- added type `WarningObject`
</details>


<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `ProductSearchStatus`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `customer-group` to type `ExtensionResourceTypeId`
- added enum `product-tailoring` to type `MessageSubscriptionResourceTypeId`
- added enum `product-tailoring` to type `ResourceTypeId`
</details>

**Import changes**

<details>
<summary>Added Type(s)</summary>

- added type `InvalidFieldsUpdateError`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.11.0...11.12.0

# 11.11.0 (2024-09-04)

## Important Information

This major release branch will be the last compatible with .NET Standard 2.1. The major release will have .NET 6 as minimum requirement. The next major release will include a refactored logger handler. Some defaults in the client configuration may be changed.

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/344
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/345
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/346
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/347
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/348
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/349
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/350
* add http version middleware by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/351

**Api changes**

<details>
<summary>Removed Method(s)</summary>

- :warning: removed method `apiRoot.withProjectKey().me().businessUnits().withId().delete()`
- :warning: removed method `apiRoot.withProjectKey().me().businessUnits().withKey().delete()`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `applicationMode` to type `CartDiscountValueAbsolute`
- added property `applicationMode` to type `CartDiscountValueAbsoluteDraft`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `DiscountApplicationMode`
- added type `DeliveryCustomFieldAddedMessage`
- added type `DeliveryCustomFieldChangedMessage`
- added type `DeliveryCustomFieldRemovedMessage`
- added type `DeliveryCustomTypeRemovedMessage`
- added type `DeliveryCustomTypeSetMessage`
- added type `DeliveryCustomFieldAddedMessagePayload`
- added type `DeliveryCustomFieldChangedMessagePayload`
- added type `DeliveryCustomFieldRemovedMessagePayload`
- added type `DeliveryCustomTypeRemovedMessagePayload`
- added type `DeliveryCustomTypeSetMessagePayload`
</details>

**Import changes**

<details>
<summary>Added Type(s)</summary>

- added type `ReferencedResourceNotFound`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.10.0...11.11.0

# 11.10.0 (2024-08-05)

**Api changes**

<details>
<summary>Removed Resource(s)</summary>

- :warning: removed resource `/{projectKey}/me/carts/key={key}`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `shopping-list` to type `ExtensionResourceTypeId`
- added enum `customer-group` to type `AttributeReferenceTypeId`
- added enum `customer-group` to type `CustomFieldReferenceValue`
</details>


<details>
<summary>Removed Method(s)</summary>

- :warning: removed method `apiRoot.withProjectKey().me().carts().withKey().get()`
- :warning: removed method `apiRoot.withProjectKey().me().carts().withKey().head()`
- :warning: removed method `apiRoot.withProjectKey().me().carts().withKey().post()`
- :warning: removed method `apiRoot.withProjectKey().me().carts().withKey().delete()`
- :warning: removed method `apiRoot.withProjectKey().me().quoteRequests().withId().delete()`
- :warning: removed method `apiRoot.withProjectKey().me().quoteRequests().withKey().delete()`
</details>

**Import changes**

<details>
<summary>Added Enum(s)</summary>

- added enum `customer-group` to type `CustomFieldReferenceValue`
</details>


<details>
<summary>Deprecated Property(s)</summary>

- property `PriceImport::publish` is removed
- property `ProductVariantImport::publish` is removed
</details>


## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/337
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/338
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/339
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/340
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/341
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/342
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/343


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.9.0...11.10.0

# 11.9.0 (2024-07-26)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/328
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/329
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/332
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/333
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/334
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/335
* fix resolving of custom fields in GraphQL module by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/336

**Api changes**

<details>
<summary>Added Enum(s)</summary>

- added enum `cart-discount` to type `CustomFieldReferenceValue`
</details>


<details>
<summary>Removed QueryParameter(s)</summary>

- :warning: removed query parameter `sort` from method `get /{projectKey}/product-projections/suggest`
- :warning: removed query parameter `offset` from method `get /{projectKey}/product-projections/suggest`
- :warning: removed query parameter `withTotal` from method `get /{projectKey}/product-projections/suggest`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `customType` of type `OrderSearchAnyValue` from type `string` to `OrderSearchCustomType`
- :warning: changed property `customType` of type `OrderSearchDateRangeValue` from type `string` to `OrderSearchCustomType`
- :warning: changed property `customType` of type `OrderSearchFullTextValue` from type `string` to `OrderSearchCustomType`
- :warning: changed property `customType` of type `OrderSearchLongRangeValue` from type `string` to `OrderSearchCustomType`
- :warning: changed property `customType` of type `OrderSearchNumberRangeValue` from type `string` to `OrderSearchCustomType`
- :warning: changed property `customType` of type `OrderSearchQueryExpressionValue` from type `string` to `OrderSearchCustomType`
- :warning: changed property `customType` of type `OrderSearchStringValue` from type `string` to `OrderSearchCustomType`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `addressId` to type `BusinessUnitAddressCustomFieldAddedMessage`
- added property `addressId` to type `BusinessUnitAddressCustomFieldChangedMessage`
- added property `addressId` to type `BusinessUnitAddressCustomFieldRemovedMessage`
- added property `addressId` to type `BusinessUnitAddressCustomTypeRemovedMessage`
- added property `addressId` to type `BusinessUnitAddressCustomTypeSetMessage`
- added property `addressId` to type `CustomerAddressCustomFieldAddedMessage`
- added property `addressId` to type `CustomerAddressCustomFieldChangedMessage`
- added property `addressId` to type `CustomerAddressCustomFieldRemovedMessage`
- added property `addressId` to type `CustomerAddressCustomTypeRemovedMessage`
- added property `addressId` to type `CustomerAddressCustomTypeSetMessage`
- added property `addressId` to type `BusinessUnitAddressCustomFieldAddedMessagePayload`
- added property `addressId` to type `BusinessUnitAddressCustomFieldChangedMessagePayload`
- added property `addressId` to type `BusinessUnitAddressCustomFieldRemovedMessagePayload`
- added property `addressId` to type `BusinessUnitAddressCustomTypeRemovedMessagePayload`
- added property `addressId` to type `BusinessUnitAddressCustomTypeSetMessagePayload`
- added property `addressId` to type `CustomerAddressCustomFieldAddedMessagePayload`
- added property `addressId` to type `CustomerAddressCustomFieldChangedMessagePayload`
- added property `addressId` to type `CustomerAddressCustomFieldRemovedMessagePayload`
- added property `addressId` to type `CustomerAddressCustomTypeRemovedMessagePayload`
- added property `addressId` to type `CustomerAddressCustomTypeSetMessagePayload`
- added property `active` to type `ShippingMethod`
- added property `active` to type `ShippingMethodDraft`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `CartChangeLineItemsOrderAction`
- added type `MyCartChangeLineItemsOrderAction`
- added type `OrderSearchCustomType`
- added type `ShippingMethodChangeActiveAction`
</details>

### Breaking changes

#### Order Search

The `customtype` parameter in an OrderSearch request has been changed from a String to an Enum.

#### GraphQL module

We released a fix for the GraphQL module. Previously Json-Values in GraphQL were tried to be deserialized to a String. This caused Runtime exceptions for example when trying to deserialize CustomFields which where not Strings. The GraphQL module now deserializes Json into a `System.Text.Json.Nodes.JsonValue`. So they have to be deserialized to a specific type when trying to access it. An example can be found here:

https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/blob/0f164fc8bdf173b7203ff2c3d1afb2913c9b95ac/commercetools.Sdk/IntegrationTests/commercetools.Api.IntegrationTests/Type/TypeIntegrationTests.cs#L148-L151

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.8.0...11.9.0

# 11.8.0 (2024-07-03)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/313
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/314
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/315
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/316
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/317
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/318
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/319
* DEVX-330 add dynatrace example app by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/320
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/321
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/322
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/323
* add datadog example app by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/324
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/325
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/326
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/327

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

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.7.0...11.8.0

# 11.7.0 (2024-05-30)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/306
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/307
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/308
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/309
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/310
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/311
* add option to specify attribute type mapping explicit by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/312


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.6.0...11.7.0

# 11.6.0 (2024-05-15)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/288
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/289
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/290
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/291
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/292
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/295
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/296
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/297
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/298
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/301
* update bootstrap, jquery, jquery-validation by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/302
* update dependencies by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/303
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/304
* support custom correlation id provider by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/305

**Api changes**

<details>
<summary>Added Type(s)</summary>

- added type `Attribution`
- added type `AttributionSource`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `value` of type `DirectDiscountDraft` from type `CartDiscountValue` to `CartDiscountValueDraft`
- :warning: changed property `custom` of type `MyBusinessUnitDraft` from type `CustomFields` to `CustomFieldsDraft`
- :warning: changed property `custom` of type `MyCompanyDraft` from type `CustomFields` to `CustomFieldsDraft`
- :warning: changed property `custom` of type `MyDivisionDraft` from type `CustomFields` to `CustomFieldsDraft`
</details>


<details>
<summary>Required Property(s)</summary>

- :warning: changed property `stores` of type `BusinessUnit` to be required
- :warning: changed property `stores` of type `Company` to be required
- :warning: changed property `stores` of type `Division` to be required
- :warning: changed property `stores` of type `BusinessUnitSetStoresAction` to be required
- :warning: changed property `stores` of type `CartDiscountSetStoresAction` to be required
- :warning: changed property `stores` of type `Customer` to be required
- :warning: changed property `stores` of type `CustomerSetStoresAction` to be required
</details>


<details>
<summary>Added Property(s)</summary>

- added property `attributedTo` to type `CreatedBy`
- added property `attributedTo` to type `LastModifiedBy`
- added property `postFilter` to type `ProductSearchRequest`
</details>


<details>
<summary>Removed Method(s)</summary>

- :warning: removed method `apiRoot.withProjectKey().products().search().head()`
</details>

**Import changes**

<details>
<summary>Added Type(s)</summary>

- added type `DiscountCodeImportRequest`
- added type `DiscountCodeImport`
</details>


<details>
<summary>MarkDeprecated Property(s)</summary>

- marked property `PriceImport::publish` as deprecated
- marked property `ProductVariantImport::publish` as deprecated
</details>


<details>
<summary>Added Property(s)</summary>

- added property `staged` to type `PriceImport`
- added property `staged` to type `ProductVariantImport`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKeyValue().discountCodes().importContainers().withImportContainerKeyValue().post()`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/discount-codes`
- added resource `/{projectKey}/discount-codes/import-containers`
- added resource `/{projectKey}/discount-codes/import-containers/{importContainerKey}`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `discount-code` to type `ImportResourceType`
</details>

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.5.0...11.6.0

# 11.5.0 (2024-04-01)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/278
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/279
* Create changelog.js by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/281
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/282
* Remove ML from readme by @industrian in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/284
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/283
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/285
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/286
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/287


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.4.0...11.5.0

# 11.4.0 (2024-02-21)

## What's Changed
* Update changelog by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/272
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/274
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/276
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/277
* fixes query parameters of type int to accept long values #269

**Api changes**

<details>
<summary>Required Property(s)</summary>

- changed property `priceMode` of type `CustomLineItemDraft` to be optional
- changed property `oldShipmentState` of type `OrderShipmentStateChangedMessage` to be optional
- changed property `oldOrderState` of type `OrderStateChangedMessage` to be optional
- changed property `oldShipmentState` of type `OrderShipmentStateChangedMessagePayload` to be optional
- changed property `oldOrderState` of type `OrderStateChangedMessagePayload` to be optional
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.3.0...11.4.0

# 11.3.0 (2024-02-16)

## What's Changed
* add test for custom logging by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/258
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/257
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/260
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/263
* Update CODEOWNERS by @evansinho in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/264
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/265
* Avoid using strings when deserializing by @Henr1k80  in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/267 https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/266
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/268
* Update generated SDKs by @ct-sdks in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/271
* Add Integration Tests for .NET SDK by @ajimae in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/261

**Api changes**

<details>
<summary>Added Type(s)</summary>

- added type `DiscountedLineItemPortionDraft`
- added type `DiscountCodeSetKeyAction`
- added type `CartDiscountCreatedMessage`
- added type `CartDiscountDeletedMessage`
- added type `CartDiscountStoreAddedMessage`
- added type `CartDiscountStoreRemovedMessage`
- added type `CartDiscountStoresSetMessage`
- added type `DiscountCodeCreatedMessage`
- added type `DiscountCodeDeletedMessage`
- added type `DiscountCodeKeySetMessage`
- added type `CartDiscountCreatedMessagePayload`
- added type `CartDiscountDeletedMessagePayload`
- added type `CartDiscountStoreAddedMessagePayload`
- added type `CartDiscountStoreRemovedMessagePayload`
- added type `CartDiscountStoresSetMessagePayload`
- added type `DiscountCodeCreatedMessagePayload`
- added type `DiscountCodeDeletedMessagePayload`
- added type `DiscountCodeKeySetMessagePayload`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `includedDiscounts` of type `DiscountedLineItemPriceDraft` from type `DiscountedLineItemPortion[]` to `DiscountedLineItemPortionDraft[]`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `perMethodExternalTaxRate` to type `CartAddLineItemAction`
- added property `key` to type `DiscountCode`
- added property `key` to type `DiscountCodeDraft`
- added property `shippingMode` to type `MyCartDraft`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().discountCodes().withKey().get()`
- added method `apiRoot.withProjectKey().discountCodes().withKey().head()`
- added method `apiRoot.withProjectKey().discountCodes().withKey().post()`
- added method `apiRoot.withProjectKey().discountCodes().withKey().delete()`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/discount-codes/key={key}`
</details>

## New Contributors
* @ct-sdks made their first contribution in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/260
* @evansinho made their first contribution in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/264
* @ajimae made their first contribution in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/261
* @Henr1k80  made their first contribution in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/267 https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/266

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.2.0...11.3.0

# 11.2.0 (2024-01-12)

## What's Changed
* add newrelic example app by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/254
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/253
* add option to register custom loggerhandler by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/256
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/255

**Api changes**

<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `expand` to method `get /{projectKey}/in-store/key={storeKey}/cart-discounts`
- added query parameter `sort` to method `get /{projectKey}/in-store/key={storeKey}/cart-discounts`
- added query parameter `limit` to method `get /{projectKey}/in-store/key={storeKey}/cart-discounts`
- added query parameter `offset` to method `get /{projectKey}/in-store/key={storeKey}/cart-discounts`
- added query parameter `withTotal` to method `get /{projectKey}/in-store/key={storeKey}/cart-discounts`
- added query parameter `where` to method `get /{projectKey}/in-store/key={storeKey}/cart-discounts`
- added query parameter `/^var[.][a-zA-Z0-9]+$/` to method `get /{projectKey}/in-store/key={storeKey}/cart-discounts`
- added query parameter `expand` to method `post /{projectKey}/in-store/key={storeKey}/cart-discounts`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `ApprovalFlowSetCustomFieldAction`
- added type `ApprovalFlowSetCustomTypeAction`
- added type `CustomerEmailTokenReference`
- added type `CustomerPasswordTokenReference`
</details>


<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `NotEnabledError`
- :warning: removed type `GraphQLNotEnabledError`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().head()`
- added method `apiRoot.withProjectKey().associateRoles().head()`
- added method `apiRoot.withProjectKey().businessUnits().head()`
- added method `apiRoot.withProjectKey().categories().head()`
- added method `apiRoot.withProjectKey().carts().head()`
- added method `apiRoot.withProjectKey().cartDiscounts().head()`
- added method `apiRoot.withProjectKey().channels().head()`
- added method `apiRoot.withProjectKey().customers().head()`
- added method `apiRoot.withProjectKey().customerGroups().head()`
- added method `apiRoot.withProjectKey().customObjects().head()`
- added method `apiRoot.withProjectKey().discountCodes().head()`
- added method `apiRoot.withProjectKey().inventory().head()`
- added method `apiRoot.withProjectKey().messages().head()`
- added method `apiRoot.withProjectKey().orders().head()`
- added method `apiRoot.withProjectKey().payments().head()`
- added method `apiRoot.withProjectKey().productDiscounts().head()`
- added method `apiRoot.withProjectKey().productProjections().head()`
- added method `apiRoot.withProjectKey().productSelections().head()`
- added method `apiRoot.withProjectKey().quotes().head()`
- added method `apiRoot.withProjectKey().quoteRequests().head()`
- added method `apiRoot.withProjectKey().stagedQuotes().head()`
- added method `apiRoot.withProjectKey().reviews().head()`
- added method `apiRoot.withProjectKey().shippingMethods().head()`
- added method `apiRoot.withProjectKey().shoppingLists().head()`
- added method `apiRoot.withProjectKey().states().head()`
- added method `apiRoot.withProjectKey().subscriptions().head()`
- added method `apiRoot.withProjectKey().taxCategories().head()`
- added method `apiRoot.withProjectKey().types().head()`
- added method `apiRoot.withProjectKey().zones().head()`
- added method `apiRoot.withProjectKey().extensions().head()`
- added method `apiRoot.withProjectKey().apiClients().head()`
- added method `apiRoot.withProjectKey().stores().head()`
- added method `apiRoot.withProjectKey().standalonePrices().head()`
- added method `apiRoot.withProjectKey().attributeGroups().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().businessUnits().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().businessUnits().withKey().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().businessUnits().withId().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quotes().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quoteRequests().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().withKey().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().withId().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().withOrderNumber().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().withId().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quotes().withKey().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quotes().withId().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quoteRequests().withKey().head()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quoteRequests().withId().head()`
- added method `apiRoot.withProjectKey().associateRoles().withKey().head()`
- added method `apiRoot.withProjectKey().associateRoles().withId().head()`
- added method `apiRoot.withProjectKey().businessUnits().withKey().head()`
- added method `apiRoot.withProjectKey().businessUnits().withId().head()`
- added method `apiRoot.withProjectKey().categories().withKey().head()`
- added method `apiRoot.withProjectKey().categories().withId().head()`
- added method `apiRoot.withProjectKey().carts().withCustomerId().head()`
- added method `apiRoot.withProjectKey().carts().withKey().head()`
- added method `apiRoot.withProjectKey().carts().withId().head()`
- added method `apiRoot.withProjectKey().cartDiscounts().withKey().head()`
- added method `apiRoot.withProjectKey().cartDiscounts().withId().head()`
- added method `apiRoot.withProjectKey().channels().withId().head()`
- added method `apiRoot.withProjectKey().customers().withKey().head()`
- added method `apiRoot.withProjectKey().customers().withId().head()`
- added method `apiRoot.withProjectKey().customerGroups().withKey().head()`
- added method `apiRoot.withProjectKey().customerGroups().withId().head()`
- added method `apiRoot.withProjectKey().discountCodes().withId().head()`
- added method `apiRoot.withProjectKey().inventory().withId().head()`
- added method `apiRoot.withProjectKey().inventory().withKey().head()`
- added method `apiRoot.withProjectKey().messages().withId().head()`
- added method `apiRoot.withProjectKey().orders().withOrderNumber().head()`
- added method `apiRoot.withProjectKey().orders().edits().head()`
- added method `apiRoot.withProjectKey().orders().withId().head()`
- added method `apiRoot.withProjectKey().orders().edits().withKey().head()`
- added method `apiRoot.withProjectKey().orders().edits().withId().head()`
- added method `apiRoot.withProjectKey().payments().withKey().head()`
- added method `apiRoot.withProjectKey().payments().withId().head()`
- added method `apiRoot.withProjectKey().productDiscounts().withKey().head()`
- added method `apiRoot.withProjectKey().productDiscounts().withId().head()`
- added method `apiRoot.withProjectKey().productProjections().withKey().head()`
- added method `apiRoot.withProjectKey().productProjections().withId().head()`
- added method `apiRoot.withProjectKey().productSelections().withKey().head()`
- added method `apiRoot.withProjectKey().productSelections().withId().head()`
- added method `apiRoot.withProjectKey().quotes().withKey().head()`
- added method `apiRoot.withProjectKey().quotes().withId().head()`
- added method `apiRoot.withProjectKey().quoteRequests().withKey().head()`
- added method `apiRoot.withProjectKey().quoteRequests().withId().head()`
- added method `apiRoot.withProjectKey().stagedQuotes().withKey().head()`
- added method `apiRoot.withProjectKey().stagedQuotes().withId().head()`
- added method `apiRoot.withProjectKey().reviews().withKey().head()`
- added method `apiRoot.withProjectKey().reviews().withId().head()`
- added method `apiRoot.withProjectKey().shippingMethods().withKey().head()`
- added method `apiRoot.withProjectKey().shippingMethods().matchingCart().head()`
- added method `apiRoot.withProjectKey().shippingMethods().matchingCartLocation().head()`
- added method `apiRoot.withProjectKey().shippingMethods().matchingOrderedit().head()`
- added method `apiRoot.withProjectKey().shippingMethods().matchingLocation().head()`
- added method `apiRoot.withProjectKey().shippingMethods().withId().head()`
- added method `apiRoot.withProjectKey().shoppingLists().withKey().head()`
- added method `apiRoot.withProjectKey().shoppingLists().withId().head()`
- added method `apiRoot.withProjectKey().states().withKey().head()`
- added method `apiRoot.withProjectKey().states().withId().head()`
- added method `apiRoot.withProjectKey().subscriptions().withKey().head()`
- added method `apiRoot.withProjectKey().subscriptions().withId().head()`
- added method `apiRoot.withProjectKey().taxCategories().withKey().head()`
- added method `apiRoot.withProjectKey().taxCategories().withId().head()`
- added method `apiRoot.withProjectKey().types().withKey().head()`
- added method `apiRoot.withProjectKey().types().withId().head()`
- added method `apiRoot.withProjectKey().zones().withKey().head()`
- added method `apiRoot.withProjectKey().zones().withId().head()`
- added method `apiRoot.withProjectKey().me().activeCart().head()`
- added method `apiRoot.withProjectKey().me().businessUnits().head()`
- added method `apiRoot.withProjectKey().me().carts().head()`
- added method `apiRoot.withProjectKey().me().orders().head()`
- added method `apiRoot.withProjectKey().me().payments().head()`
- added method `apiRoot.withProjectKey().me().quoteRequests().head()`
- added method `apiRoot.withProjectKey().me().quotes().head()`
- added method `apiRoot.withProjectKey().me().shoppingLists().head()`
- added method `apiRoot.withProjectKey().me().businessUnits().withId().head()`
- added method `apiRoot.withProjectKey().me().businessUnits().withKey().head()`
- added method `apiRoot.withProjectKey().me().carts().withKey().head()`
- added method `apiRoot.withProjectKey().me().carts().withId().head()`
- added method `apiRoot.withProjectKey().me().orders().withId().head()`
- added method `apiRoot.withProjectKey().me().payments().withId().head()`
- added method `apiRoot.withProjectKey().me().quoteRequests().withId().head()`
- added method `apiRoot.withProjectKey().me().quoteRequests().withKey().head()`
- added method `apiRoot.withProjectKey().me().quotes().withId().head()`
- added method `apiRoot.withProjectKey().me().quotes().withKey().head()`
- added method `apiRoot.withProjectKey().me().shoppingLists().withId().head()`
- added method `apiRoot.withProjectKey().me().shoppingLists().withKey().head()`
- added method `apiRoot.withProjectKey().extensions().withKey().head()`
- added method `apiRoot.withProjectKey().extensions().withId().head()`
- added method `apiRoot.withProjectKey().apiClients().withId().head()`
- added method `apiRoot.withProjectKey().stores().withKey().head()`
- added method `apiRoot.withProjectKey().stores().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().carts().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().orders().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().customers().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().shoppingLists().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().carts().withCustomerId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().carts().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().carts().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().orders().withOrderNumber().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().orders().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().me().carts().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().me().orders().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().me().activeCart().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().me().shoppingLists().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().me().carts().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().me().orders().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().me().shoppingLists().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().me().shoppingLists().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().customers().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().customers().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().shippingMethods().matchingCart().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().shoppingLists().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().shoppingLists().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().productProjections().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().productProjections().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().withId().head()`
- added method `apiRoot.withProjectKey().standalonePrices().withKey().head()`
- added method `apiRoot.withProjectKey().standalonePrices().withId().head()`
- added method `apiRoot.withProjectKey().attributeGroups().withKey().head()`
- added method `apiRoot.withProjectKey().attributeGroups().withId().head()`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `custom` to type `ApprovalFlow`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `approval-flow` to type `ReferenceTypeId`
- added enum `approval-rule` to type `ReferenceTypeId`
- added enum `customer-email-token` to type `ReferenceTypeId`
- added enum `customer-password-token` to type `ReferenceTypeId`
- added enum `associate-role` to type `AttributeReferenceTypeId`
- added enum `business-unit` to type `AttributeReferenceTypeId`
- added enum `cart-discount` to type `AttributeReferenceTypeId`
- added enum `approval-flow` to type `ChangeSubscriptionResourceTypeId`
- added enum `approval-rule` to type `ChangeSubscriptionResourceTypeId`
- added enum `approval-flow` to type `MessageSubscriptionResourceTypeId`
- added enum `approval-rule` to type `MessageSubscriptionResourceTypeId`
- added enum `customer-email-token` to type `MessageSubscriptionResourceTypeId`
- added enum `customer-group` to type `MessageSubscriptionResourceTypeId`
- added enum `customer-password-token` to type `MessageSubscriptionResourceTypeId`
- added enum `approval-flow` to type `CustomFieldReferenceValue`
- added enum `approval-flow` to type `ResourceTypeId`
</details>


<details>
<summary>Changed MethodResponseBody(s)</summary>

- :warning: changed response body for `200: application/json` of method `get /{projectKey}/in-store/key={storeKey}/cart-discounts` from type `CartDiscount` to `CartDiscountPagedQueryResponse`
</details>

**History changes**

<details>
<summary>Added Type(s)</summary>

- added type `AttributeLocalizedEnumValue`
- added type `AttributePlainEnumValue`
- added type `ChannelRoleEnum`
- added type `StateRoleEnum`
- added type `StateTypeEnum`
</details>


<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `ChannelRole`
- :warning: removed type `StateRole`
- :warning: removed type `StateType`
</details>


<details>
<summary>Removed Property(s)</summary>

- :warning: removed property `previousValue` from type `AddAddressChange`
- :warning: removed property `previousValue` from type `AddLocationChange`
- :warning: removed property `nextValue` from type `RemoveLocationChange`
- :warning: removed property `nextValue` from type `RemoveTaxRateChange`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `previousValue` of type `AddChannelRolesChange` from type `ChannelRole[]` to `ChannelRoleEnum[]`
- :warning: changed property `nextValue` of type `AddChannelRolesChange` from type `ChannelRole[]` to `ChannelRoleEnum[]`
- :warning: changed property `nextValue` of type `AddLocalizedEnumValueChange` from type `LocalizedEnumValue` to `AttributeLocalizedEnumValue`
- :warning: changed property `nextValue` of type `AddPlainEnumValueChange` from type `EnumValue` to `AttributePlainEnumValue`
- :warning: changed property `previousValue` of type `AddStateRolesChange` from type `StateRole[]` to `StateRoleEnum[]`
- :warning: changed property `nextValue` of type `AddStateRolesChange` from type `StateRole[]` to `StateRoleEnum[]`
- :warning: changed property `previousValue` of type `ChangeStateTypeChange` from type `StateType` to `StateTypeEnum`
- :warning: changed property `nextValue` of type `ChangeStateTypeChange` from type `StateType` to `StateTypeEnum`
- :warning: changed property `previousValue` of type `RemoveChannelRolesChange` from type `ChannelRole[]` to `ChannelRoleEnum[]`
- :warning: changed property `nextValue` of type `RemoveChannelRolesChange` from type `ChannelRole[]` to `ChannelRoleEnum[]`
- :warning: changed property `previousValue` of type `RemoveStateRolesChange` from type `StateRole[]` to `StateRoleEnum[]`
- :warning: changed property `nextValue` of type `RemoveStateRolesChange` from type `StateRole[]` to `StateRoleEnum[]`
- :warning: changed property `previousValue` of type `SetChannelRolesChange` from type `ChannelRole[]` to `ChannelRoleEnum[]`
- :warning: changed property `nextValue` of type `SetChannelRolesChange` from type `ChannelRole[]` to `ChannelRoleEnum[]`
- :warning: changed property `previousValue` of type `SetNameChange` from type `LocalizedString` to `string`
- :warning: changed property `nextValue` of type `SetNameChange` from type `LocalizedString` to `string`
- :warning: changed property `previousValue` of type `SetStateRolesChange` from type `StateRole[]` to `StateRoleEnum[]`
- :warning: changed property `nextValue` of type `SetStateRolesChange` from type `StateRole[]` to `StateRoleEnum[]`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.1.0...11.2.0

# 11.1.0 (2023-10-09)

## What's Changed
* change priority for attribute type deserialization by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/252
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/250

**Api changes**

<details>
<summary>Added Property(s)</summary>

- added property `discountOnTotalPrice` to type `Cart`
- added property `discountOnTotalPrice` to type `StagedOrder`
- added property `custom` to type `StagedOrderAddParcelToDeliveryAction`
- added property `discountOnTotalPrice` to type `Order`
- added property `custom` to type `OrderAddParcelToDeliveryAction`
</details>


<details>
<summary>Changed MethodResponseBody(s)</summary>

- :warning: changed response body for `200: application/json` of method `get /{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/approval-rules` from type `<<resourceQueryType>>` to `ApprovalRulePagedQueryResponse`
- :warning: changed response body for `200: application/json` of method `get /{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/approval-flows` from type `<<resourceQueryType>>` to `ApprovalFlowPagedQueryResponse`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `ApprovalFlowPagedQueryResponse`
- added type `ApprovalRulePagedQueryResponse`
- added type `CartDiscountTotalPriceTarget`
- added type `DiscountOnTotalPrice`
- added type `DiscountedTotalPricePortion`
- added type `CustomerEmailTokenCreatedMessage`
- added type `CustomerPasswordTokenCreatedMessage`
- added type `CustomerEmailTokenCreatedMessagePayload`
- added type `CustomerPasswordTokenCreatedMessagePayload`
</details>

**Import changes**

<details>
<summary>Added Property(s)</summary>

- added property `product` to type `ProductVariantPatch`
</details>

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/11.0.0...11.1.0

# 11.0.0 (2023-09-19)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/249

**Api changes**

<details>
<summary>Removed Resource(s)</summary>

- :warning: removed resource `/{projectKey}/me/payments/key={key}`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/approval-rules`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/approval-flows`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/approval-rules/{ID}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/approval-rules/key={key}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/approval-flows/{ID}`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `CreateApprovalRules` to type `Permission`
- added enum `UpdateApprovalRules` to type `Permission`
- added enum `UpdateApprovalFlows` to type `Permission`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().approvalRules().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().approvalRules().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().approvalFlows().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().approvalRules().withId().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().approvalRules().withId().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().approvalRules().withKey().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().approvalRules().withKey().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().approvalFlows().withId().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().approvalFlows().withId().post()`
</details>


<details>
<summary>Removed Method(s)</summary>

- :warning: removed method `apiRoot.withProjectKey().me().payments().withKey().get()`
- :warning: removed method `apiRoot.withProjectKey().me().payments().withKey().post()`
- :warning: removed method `apiRoot.withProjectKey().me().payments().withKey().delete()`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `ApprovalFlow`
- added type `ApprovalFlowApproval`
- added type `ApprovalFlowApproveAction`
- added type `ApprovalFlowRejectAction`
- added type `ApprovalFlowRejection`
- added type `ApprovalFlowStatus`
- added type `ApprovalFlowUpdate`
- added type `ApprovalFlowUpdateAction`
- added type `ApprovalRule`
- added type `ApprovalRuleDraft`
- added type `ApprovalRuleSetApproversAction`
- added type `ApprovalRuleSetDescriptionAction`
- added type `ApprovalRuleSetKeyAction`
- added type `ApprovalRuleSetNameAction`
- added type `ApprovalRuleSetPredicateAction`
- added type `ApprovalRuleSetRequestersAction`
- added type `ApprovalRuleSetStatusAction`
- added type `ApprovalRuleStatus`
- added type `ApprovalRuleUpdate`
- added type `ApprovalRuleUpdateAction`
- added type `ApproverConjunction`
- added type `ApproverConjunctionDraft`
- added type `ApproverDisjunction`
- added type `ApproverDisjunctionDraft`
- added type `ApproverHierarchy`
- added type `ApproverHierarchyDraft`
- added type `RuleApprover`
- added type `RuleApproverDraft`
- added type `RuleRequester`
- added type `RuleRequesterDraft`
- added type `ApprovalFlowApprovedMessage`
- added type `ApprovalFlowCompletedMessage`
- added type `ApprovalFlowCreatedMessage`
- added type `ApprovalFlowRejectedMessage`
- added type `ApprovalRuleApproversSetMessage`
- added type `ApprovalRuleCreatedMessage`
- added type `ApprovalRuleDescriptionSetMessage`
- added type `ApprovalRuleKeySetMessage`
- added type `ApprovalRuleNameSetMessage`
- added type `ApprovalRulePredicateSetMessage`
- added type `ApprovalRuleRequestersSetMessage`
- added type `ApprovalRuleStatusSetMessage`
- added type `BusinessUnitAddressCustomFieldAddedMessage`
- added type `BusinessUnitAddressCustomFieldChangedMessage`
- added type `BusinessUnitAddressCustomFieldRemovedMessage`
- added type `BusinessUnitAddressCustomTypeRemovedMessage`
- added type `BusinessUnitAddressCustomTypeSetMessage`
- added type `BusinessUnitCustomFieldAddedMessage`
- added type `BusinessUnitCustomFieldChangedMessage`
- added type `BusinessUnitCustomFieldRemovedMessage`
- added type `BusinessUnitCustomTypeRemovedMessage`
- added type `BusinessUnitCustomTypeSetMessage`
- added type `CustomerAddressCustomFieldAddedMessage`
- added type `CustomerAddressCustomFieldChangedMessage`
- added type `CustomerAddressCustomFieldRemovedMessage`
- added type `CustomerAddressCustomTypeRemovedMessage`
- added type `CustomerAddressCustomTypeSetMessage`
- added type `CustomerCustomFieldAddedMessage`
- added type `CustomerCustomFieldChangedMessage`
- added type `CustomerCustomFieldRemovedMessage`
- added type `CustomerCustomTypeRemovedMessage`
- added type `CustomerCustomTypeSetMessage`
- added type `CustomerGroupCustomFieldAddedMessage`
- added type `CustomerGroupCustomFieldChangedMessage`
- added type `CustomerGroupCustomFieldRemovedMessage`
- added type `CustomerGroupCustomTypeRemovedMessage`
- added type `CustomerGroupCustomTypeSetMessage`
- added type `ApprovalFlowApprovedMessagePayload`
- added type `ApprovalFlowCompletedMessagePayload`
- added type `ApprovalFlowCreatedMessagePayload`
- added type `ApprovalFlowRejectedMessagePayload`
- added type `ApprovalRuleApproversSetMessagePayload`
- added type `ApprovalRuleCreatedMessagePayload`
- added type `ApprovalRuleDescriptionSetMessagePayload`
- added type `ApprovalRuleKeySetMessagePayload`
- added type `ApprovalRuleNameSetMessagePayload`
- added type `ApprovalRulePredicateSetMessagePayload`
- added type `ApprovalRuleRequestersSetMessagePayload`
- added type `ApprovalRuleStatusSetMessagePayload`
- added type `BusinessUnitAddressCustomFieldAddedMessagePayload`
- added type `BusinessUnitAddressCustomFieldChangedMessagePayload`
- added type `BusinessUnitAddressCustomFieldRemovedMessagePayload`
- added type `BusinessUnitAddressCustomTypeRemovedMessagePayload`
- added type `BusinessUnitAddressCustomTypeSetMessagePayload`
- added type `BusinessUnitCustomFieldAddedMessagePayload`
- added type `BusinessUnitCustomFieldChangedMessagePayload`
- added type `BusinessUnitCustomFieldRemovedMessagePayload`
- added type `BusinessUnitCustomTypeRemovedMessagePayload`
- added type `BusinessUnitCustomTypeSetMessagePayload`
- added type `CustomerAddressCustomFieldAddedMessagePayload`
- added type `CustomerAddressCustomFieldChangedMessagePayload`
- added type `CustomerAddressCustomFieldRemovedMessagePayload`
- added type `CustomerAddressCustomTypeRemovedMessagePayload`
- added type `CustomerAddressCustomTypeSetMessagePayload`
- added type `CustomerCustomFieldAddedMessagePayload`
- added type `CustomerCustomFieldChangedMessagePayload`
- added type `CustomerCustomFieldRemovedMessagePayload`
- added type `CustomerCustomTypeRemovedMessagePayload`
- added type `CustomerCustomTypeSetMessagePayload`
- added type `CustomerGroupCustomFieldAddedMessagePayload`
- added type `CustomerGroupCustomFieldChangedMessagePayload`
- added type `CustomerGroupCustomFieldRemovedMessagePayload`
- added type `CustomerGroupCustomTypeRemovedMessagePayload`
- added type `CustomerGroupCustomTypeSetMessagePayload`
</details>

**History changes**

<details>
<summary>Added Property(s)</summary>

- added property `businessUnit` to type `Record`
</details>


<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `businessUnit` to method `get /{projectKey}`
- added query parameter `businessUnit` to method `get /{projectKey}/{resourceType}`
- added query parameter `businessUnit` to method `get /{projectKey}/{resourceType}/{ID}`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/10.0.1...11.0.0

# 10.1.0 (2023-09-04)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/248


**Api changes**

<details>
<summary>Added Type(s)</summary>

- added type `CustomerAddressCustomFieldAddedMessage`
- added type `CustomerAddressCustomFieldChangedMessage`
- added type `CustomerAddressCustomFieldRemovedMessage`
- added type `CustomerAddressCustomTypeRemovedMessage`
- added type `CustomerAddressCustomTypeSetMessage`
- added type `CustomerCustomFieldAddedMessage`
- added type `CustomerCustomFieldChangedMessage`
- added type `CustomerCustomFieldRemovedMessage`
- added type `CustomerCustomTypeRemovedMessage`
- added type `CustomerCustomTypeSetMessage`
- added type `CustomerAddressCustomFieldAddedMessagePayload`
- added type `CustomerAddressCustomFieldChangedMessagePayload`
- added type `CustomerAddressCustomFieldRemovedMessagePayload`
- added type `CustomerAddressCustomTypeRemovedMessagePayload`
- added type `CustomerAddressCustomTypeSetMessagePayload`
- added type `CustomerCustomFieldAddedMessagePayload`
- added type `CustomerCustomFieldChangedMessagePayload`
- added type `CustomerCustomFieldRemovedMessagePayload`
- added type `CustomerCustomTypeRemovedMessagePayload`
- added type `CustomerCustomTypeSetMessagePayload`
- added type `CustomerMessagePayload`
</details>


<details>
<summary>Removed Method(s)</summary>

- :warning: removed method `apiRoot.withProjectKey().me().payments().withKey().get()`
- :warning: removed method `apiRoot.withProjectKey().me().payments().withKey().post()`
- :warning: removed method `apiRoot.withProjectKey().me().payments().withKey().delete()`
</details>


<details>
<summary>Removed Resource(s)</summary>

- :warning: removed resource `/{projectKey}/me/payments/key={key}`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/10.0.0...10.1.0

# 10.0.0 (2023-08-31)

We updated dependencies like `Microsoft.Extensions.*` and `System.Text.Json` to 6.x versions. The SDK packages use as the target framework `netstandard2.1`. The artifacts are now built using .NET 6.0 for compilation. The test projects are built using .NET 6. This means the different packages may still be used in a .NET Core 3.1 application but we don't guarantee the support any more.

## What's Changed

* OpenTelemetry by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/245
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/244
* Update dependencies to dotnet 6 versions by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/246
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/247

**Api changes**

<details>
<summary>Added Type(s)</summary>

- added type `MethodExternalTaxRateDraft`
- added type `QuoteRenegotiationRequestedMessage`
- added type `QuoteRenegotiationRequestedMessagePayload`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `perMethodExternalTaxRate` to type `LineItemDraft`
- added property `cart` to type `QuoteRequest`
</details>


<details>
<summary>Removed Enum(s)</summary>

- :warning: removed enum `Failed` from type `QuoteState`
</details>

**Import changes**

<details>
<summary>Added Property(s)</summary>

- added property `canceled` to type `OperationStates`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `canceled` to type `ProcessingState`
</details>

**History changes**

<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `associateId` to method `get /{projectKey}`
- added query parameter `associateId` to method `get /{projectKey}/{resourceType}`
- added query parameter `associateId` to method `get /{projectKey}/{resourceType}/{ID}`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `associate` to type `ModifiedBy`
</details>

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/9.0.0...10.0.0

# 9.0.1 (2023-08-31)

## Fixes

- revert type change for property `money` in CartDiscountValueFixed

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/9.0.0...9.0.1

# 9.0.0 (2023-08-16)

### New Features

We introduce a new GraphQL package, which allows to write type safe queries with the help from [ZeroQL](https://github.com/byme8/ZeroQL)

```
var client = provider.GetService<ProjectApiRoot>().GraphQLClient();
 
var response = await client.Query(o => o.Products(selector: r => new { results = r.Results(product => new { product.Id }) }));
```

## Breaking changes

- `expand` methods has been removed from the subscription and extension request builders
- deprecated types from business unit and associate roles have been removed
- CartDiscountValueFixed now supports HighPrecisionMoney and changed from CentPrecisionMoney to TypedMoney
- Order Edit clarifications and corrections

## What's Changed

* move mixin from RAML to partial classes by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/238
* new GraphQL package by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/239
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/240
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/241
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/242
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/243


**Api changes**

<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `money` of type `CartDiscountValueFixed` from type `CentPrecisionMoney[]` to `TypedMoney[]`
- :warning: changed property `money` of type `CartDiscountValueFixedDraft` from type `Money[]` to `TypedMoneyDraft[]`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `stores` to type `CartDiscount`
- added property `stores` to type `CartDiscountDraft`
- added property `taxedPricePortions` to type `CustomLineItem`
- added property `customLineItemKey` to type `CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction`
- added property `customLineItemKey` to type `CartChangeCustomLineItemMoneyAction`
- added property `customLineItemKey` to type `CartChangeCustomLineItemPriceModeAction`
- added property `customLineItemKey` to type `CartChangeCustomLineItemQuantityAction`
- added property `customLineItemKey` to type `CartRemoveCustomLineItemAction`
- added property `customLineItemKey` to type `CartSetCustomLineItemCustomFieldAction`
- added property `customLineItemKey` to type `CartSetCustomLineItemCustomTypeAction`
- added property `customLineItemKey` to type `CartSetCustomLineItemShippingDetailsAction`
- added property `customLineItemKey` to type `CartSetCustomLineItemTaxAmountAction`
- added property `shippingKey` to type `CartSetCustomLineItemTaxAmountAction`
- added property `customLineItemKey` to type `CartSetCustomLineItemTaxRateAction`
- added property `shippingKey` to type `CartSetCustomLineItemTaxRateAction`
- added property `associate` to type `ClientLogging`
- added property `associate` to type `CreatedBy`
- added property `associate` to type `LastModifiedBy`
- added property `key` to type `MyShoppingListAddLineItemAction`
- added property `key` to type `MyShoppingListAddTextLineItemAction`
- added property `textLineItemKey` to type `MyShoppingListChangeTextLineItemNameAction`
- added property `textLineItemKey` to type `MyShoppingListChangeTextLineItemQuantityAction`
- added property `lineItemKey` to type `MyShoppingListRemoveLineItemAction`
- added property `textLineItemKey` to type `MyShoppingListRemoveTextLineItemAction`
- added property `lineItemKey` to type `MyShoppingListSetLineItemCustomFieldAction`
- added property `textLineItemKey` to type `MyShoppingListSetTextLineItemCustomFieldAction`
- added property `textLineItemKey` to type `MyShoppingListSetTextLineItemCustomTypeAction`
- added property `textLineItemKey` to type `MyShoppingListSetTextLineItemDescriptionAction`
- added property `customLineItemKey` to type `CustomLineItemStateTransitionMessage`
- added property `lineItemKey` to type `LineItemStateTransitionMessage`
- added property `customLineItemKey` to type `OrderCustomLineItemDiscountSetMessage`
- added property `customLineItemKey` to type `OrderCustomLineItemQuantityChangedMessage`
- added property `customLineItemKey` to type `OrderCustomLineItemRemovedMessage`
- added property `lineItemKey` to type `OrderLineItemDiscountSetMessage`
- added property `lineItemKey` to type `OrderLineItemDistributionChannelSetMessage`
- added property `lineItemKey` to type `OrderLineItemRemovedMessage`
- added property `customLineItemKey` to type `CustomLineItemStateTransitionMessagePayload`
- added property `lineItemKey` to type `LineItemStateTransitionMessagePayload`
- added property `customLineItemKey` to type `OrderCustomLineItemDiscountSetMessagePayload`
- added property `customLineItemKey` to type `OrderCustomLineItemQuantityChangedMessagePayload`
- added property `customLineItemKey` to type `OrderCustomLineItemRemovedMessagePayload`
- added property `lineItemKey` to type `OrderLineItemDiscountSetMessagePayload`
- added property `lineItemKey` to type `OrderLineItemDistributionChannelSetMessagePayload`
- added property `lineItemKey` to type `OrderLineItemRemovedMessagePayload`
- added property `directDiscounts` to type `StagedOrder`
- added property `shippingDetails` to type `StagedOrderAddCustomLineItemAction`
- added property `shippingKey` to type `StagedOrderAddDeliveryAction`
- added property `inventoryMode` to type `StagedOrderAddLineItemAction`
- added property `customLineItemKey` to type `StagedOrderChangeCustomLineItemMoneyAction`
- added property `customLineItemKey` to type `StagedOrderChangeCustomLineItemQuantityAction`
- added property `customLineItemKey` to type `StagedOrderImportCustomLineItemStateAction`
- added property `lineItemKey` to type `StagedOrderImportLineItemStateAction`
- added property `customLineItemKey` to type `StagedOrderRemoveCustomLineItemAction`
- added property `customLineItemKey` to type `StagedOrderSetCustomLineItemCustomFieldAction`
- added property `customLineItemKey` to type `StagedOrderSetCustomLineItemCustomTypeAction`
- added property `customLineItemKey` to type `StagedOrderSetCustomLineItemShippingDetailsAction`
- added property `customLineItemKey` to type `StagedOrderSetCustomLineItemTaxAmountAction`
- added property `shippingKey` to type `StagedOrderSetCustomLineItemTaxAmountAction`
- added property `customLineItemKey` to type `StagedOrderSetCustomLineItemTaxRateAction`
- added property `shippingKey` to type `StagedOrderSetCustomLineItemTaxRateAction`
- added property `returnItemKey` to type `StagedOrderSetReturnItemCustomFieldAction`
- added property `returnItemKey` to type `StagedOrderSetReturnItemCustomTypeAction`
- added property `returnItemKey` to type `StagedOrderSetReturnPaymentStateAction`
- added property `returnItemKey` to type `StagedOrderSetReturnShipmentStateAction`
- added property `customLineItemKey` to type `StagedOrderTransitionCustomLineItemStateAction`
- added property `lineItemKey` to type `StagedOrderTransitionLineItemStateAction`
- added property `key` to type `CustomLineItemImportDraft`
- added property `key` to type `CustomLineItemReturnItem`
- added property `key` to type `LineItemImportDraft`
- added property `key` to type `LineItemReturnItem`
- added property `directDiscounts` to type `Order`
- added property `purchaseOrderNumber` to type `OrderImportDraft`
- added property `taxCalculationMode` to type `OrderImportDraft`
- added property `key` to type `ReturnItem`
- added property `key` to type `ReturnItemDraft`
- added property `customLineItemKey` to type `OrderImportCustomLineItemStateAction`
- added property `lineItemKey` to type `OrderImportLineItemStateAction`
- added property `customLineItemKey` to type `OrderSetCustomLineItemCustomFieldAction`
- added property `customLineItemKey` to type `OrderSetCustomLineItemCustomTypeAction`
- added property `customLineItemKey` to type `OrderSetCustomLineItemShippingDetailsAction`
- added property `returnItemKey` to type `OrderSetReturnItemCustomFieldAction`
- added property `returnItemKey` to type `OrderSetReturnItemCustomTypeAction`
- added property `returnItemKey` to type `OrderSetReturnPaymentStateAction`
- added property `returnItemKey` to type `OrderSetReturnShipmentStateAction`
- added property `customLineItemKey` to type `OrderTransitionCustomLineItemStateAction`
- added property `lineItemKey` to type `OrderTransitionLineItemStateAction`
- added property `key` to type `ShoppingListLineItem`
- added property `key` to type `ShoppingListLineItemDraft`
- added property `key` to type `TextLineItem`
- added property `key` to type `TextLineItemDraft`
- added property `key` to type `ShoppingListAddLineItemAction`
- added property `key` to type `ShoppingListAddTextLineItemAction`
- added property `lineItemKey` to type `ShoppingListChangeLineItemQuantityAction`
- added property `textLineItemKey` to type `ShoppingListChangeTextLineItemNameAction`
- added property `textLineItemKey` to type `ShoppingListChangeTextLineItemQuantityAction`
- added property `lineItemKey` to type `ShoppingListRemoveLineItemAction`
- added property `textLineItemKey` to type `ShoppingListRemoveTextLineItemAction`
- added property `lineItemKey` to type `ShoppingListSetLineItemCustomFieldAction`
- added property `lineItemKey` to type `ShoppingListSetLineItemCustomTypeAction`
- added property `textLineItemKey` to type `ShoppingListSetTextLineItemCustomFieldAction`
- added property `textLineItemKey` to type `ShoppingListSetTextLineItemCustomTypeAction`
- added property `textLineItemKey` to type `ShoppingListSetTextLineItemDescriptionAction`
</details>


<details>
<summary>Required Property(s)</summary>

- :warning: changed property `associateRoleAssignments` of type `AssociateDraft` to be required
- :warning: changed property `paymentState` of type `StagedOrderChangePaymentStateAction` to be required
- :warning: changed property `shipmentState` of type `StagedOrderChangeShipmentStateAction` to be required
- :warning: changed property `paymentState` of type `OrderChangePaymentStateAction` to be required
- :warning: changed property `shipmentState` of type `OrderChangeShipmentStateAction` to be required
- changed property `roles` of type `Associate` to be optional
- changed property `customLineItemId` of type `CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction` to be optional
- changed property `customLineItemId` of type `CartChangeCustomLineItemMoneyAction` to be optional
- changed property `customLineItemId` of type `CartChangeCustomLineItemPriceModeAction` to be optional
- changed property `customLineItemId` of type `CartChangeCustomLineItemQuantityAction` to be optional
- changed property `customLineItemId` of type `CartRemoveCustomLineItemAction` to be optional
- changed property `customLineItemId` of type `CartSetCustomLineItemCustomFieldAction` to be optional
- changed property `customLineItemId` of type `CartSetCustomLineItemCustomTypeAction` to be optional
- changed property `customLineItemId` of type `CartSetCustomLineItemShippingDetailsAction` to be optional
- changed property `customLineItemId` of type `CartSetCustomLineItemTaxAmountAction` to be optional
- changed property `customLineItemId` of type `CartSetCustomLineItemTaxRateAction` to be optional
- changed property `centAmount` of type `CentPrecisionMoneyDraft` to be optional
- changed property `centAmount` of type `TypedMoneyDraft` to be optional
- changed property `comment` of type `MyQuoteRequestDraft` to be optional
- changed property `textLineItemId` of type `MyShoppingListChangeTextLineItemNameAction` to be optional
- changed property `textLineItemId` of type `MyShoppingListChangeTextLineItemQuantityAction` to be optional
- changed property `lineItemId` of type `MyShoppingListRemoveLineItemAction` to be optional
- changed property `textLineItemId` of type `MyShoppingListRemoveTextLineItemAction` to be optional
- changed property `lineItemId` of type `MyShoppingListSetLineItemCustomFieldAction` to be optional
- changed property `textLineItemId` of type `MyShoppingListSetTextLineItemCustomFieldAction` to be optional
- changed property `textLineItemId` of type `MyShoppingListSetTextLineItemCustomTypeAction` to be optional
- changed property `textLineItemId` of type `MyShoppingListSetTextLineItemDescriptionAction` to be optional
- changed property `customLineItemId` of type `StagedOrderChangeCustomLineItemMoneyAction` to be optional
- changed property `customLineItemId` of type `StagedOrderChangeCustomLineItemQuantityAction` to be optional
- changed property `customLineItemId` of type `StagedOrderImportCustomLineItemStateAction` to be optional
- changed property `lineItemId` of type `StagedOrderImportLineItemStateAction` to be optional
- changed property `customLineItemId` of type `StagedOrderRemoveCustomLineItemAction` to be optional
- changed property `customLineItemId` of type `StagedOrderSetCustomLineItemCustomFieldAction` to be optional
- changed property `customLineItemId` of type `StagedOrderSetCustomLineItemCustomTypeAction` to be optional
- changed property `customLineItemId` of type `StagedOrderSetCustomLineItemShippingDetailsAction` to be optional
- changed property `customLineItemId` of type `StagedOrderSetCustomLineItemTaxAmountAction` to be optional
- changed property `customLineItemId` of type `StagedOrderSetCustomLineItemTaxRateAction` to be optional
- changed property `returnItemId` of type `StagedOrderSetReturnItemCustomFieldAction` to be optional
- changed property `returnItemId` of type `StagedOrderSetReturnItemCustomTypeAction` to be optional
- changed property `returnItemId` of type `StagedOrderSetReturnPaymentStateAction` to be optional
- changed property `returnItemId` of type `StagedOrderSetReturnShipmentStateAction` to be optional
- changed property `customLineItemId` of type `StagedOrderTransitionCustomLineItemStateAction` to be optional
- changed property `lineItemId` of type `StagedOrderTransitionLineItemStateAction` to be optional
- changed property `priceMode` of type `CustomLineItemImportDraft` to be optional
- changed property `customLineItemId` of type `OrderImportCustomLineItemStateAction` to be optional
- changed property `lineItemId` of type `OrderImportLineItemStateAction` to be optional
- changed property `customLineItemId` of type `OrderSetCustomLineItemCustomFieldAction` to be optional
- changed property `customLineItemId` of type `OrderSetCustomLineItemCustomTypeAction` to be optional
- changed property `customLineItemId` of type `OrderSetCustomLineItemShippingDetailsAction` to be optional
- changed property `returnItemId` of type `OrderSetReturnItemCustomFieldAction` to be optional
- changed property `returnItemId` of type `OrderSetReturnItemCustomTypeAction` to be optional
- changed property `returnItemId` of type `OrderSetReturnPaymentStateAction` to be optional
- changed property `returnItemId` of type `OrderSetReturnShipmentStateAction` to be optional
- changed property `customLineItemId` of type `OrderTransitionCustomLineItemStateAction` to be optional
- changed property `lineItemId` of type `OrderTransitionLineItemStateAction` to be optional
- changed property `comment` of type `QuoteRequestDraft` to be optional
- changed property `lineItemId` of type `ShoppingListChangeLineItemQuantityAction` to be optional
- changed property `textLineItemId` of type `ShoppingListChangeTextLineItemNameAction` to be optional
- changed property `textLineItemId` of type `ShoppingListChangeTextLineItemQuantityAction` to be optional
- changed property `lineItemId` of type `ShoppingListRemoveLineItemAction` to be optional
- changed property `textLineItemId` of type `ShoppingListRemoveTextLineItemAction` to be optional
- changed property `lineItemId` of type `ShoppingListSetLineItemCustomFieldAction` to be optional
- changed property `lineItemId` of type `ShoppingListSetLineItemCustomTypeAction` to be optional
- changed property `textLineItemId` of type `ShoppingListSetTextLineItemCustomFieldAction` to be optional
- changed property `textLineItemId` of type `ShoppingListSetTextLineItemCustomTypeAction` to be optional
- changed property `textLineItemId` of type `ShoppingListSetTextLineItemDescriptionAction` to be optional
</details>


<details>
<summary>Deprecated Property(s)</summary>

- property `Associate::roles` is removed
- property `AssociateDraft::roles` is removed
- property `IndividualExclusionProductSelectionType::type` is removed
- property `IndividualProductSelectionType::type` is removed
- property `ProductSelection::type` is removed
- property `ProductSelectionDraft::type` is removed
- property `ProductSelectionType::type` is removed
</details>


<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `where` to method `get /{projectKey}/in-store/key={storeKey}/product-selection-assignments`
- added query parameter `/^var[.][a-zA-Z0-9]+$/` to method `get /{projectKey}/in-store/key={storeKey}/product-selection-assignments`
</details>


<details>
<summary>Removed QueryParameter(s)</summary>

- :warning: removed query parameter `expand` from method `get /{projectKey}/subscriptions`
- :warning: removed query parameter `expand` from method `post /{projectKey}/subscriptions`
- :warning: removed query parameter `expand` from method `get /{projectKey}/extensions`
- :warning: removed query parameter `expand` from method `post /{projectKey}/extensions`
- :warning: removed query parameter `expand` from method `get /{projectKey}/subscriptions/key={key}`
- :warning: removed query parameter `expand` from method `post /{projectKey}/subscriptions/key={key}`
- :warning: removed query parameter `expand` from method `delete /{projectKey}/subscriptions/key={key}`
- :warning: removed query parameter `expand` from method `get /{projectKey}/subscriptions/{ID}`
- :warning: removed query parameter `expand` from method `post /{projectKey}/subscriptions/{ID}`
- :warning: removed query parameter `expand` from method `delete /{projectKey}/subscriptions/{ID}`
- :warning: removed query parameter `expand` from method `get /{projectKey}/extensions/key={key}`
- :warning: removed query parameter `expand` from method `post /{projectKey}/extensions/key={key}`
- :warning: removed query parameter `expand` from method `delete /{projectKey}/extensions/key={key}`
- :warning: removed query parameter `expand` from method `get /{projectKey}/extensions/{ID}`
- :warning: removed query parameter `expand` from method `post /{projectKey}/extensions/{ID}`
- :warning: removed query parameter `expand` from method `delete /{projectKey}/extensions/{ID}`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `CartDiscountAddStoreAction`
- added type `CartDiscountRemoveStoreAction`
- added type `CartDiscountSetStoresAction`
- added type `ContentTooLargeError`
- added type `MaxCartDiscountsReachedError`
- added type `MaxStoreReferencesReachedError`
- added type `StoreCartDiscountsLimitReachedError`
- added type `GraphQLContentTooLargeError`
- added type `GraphQLMaxCartDiscountsReachedError`
- added type `GraphQLMaxStoreReferencesReachedError`
- added type `GraphQLStoreCartDiscountsLimitReachedError`
- added type `BusinessUnitParentChangedMessage`
- added type `OrderCustomFieldAddedMessage`
- added type `OrderCustomFieldChangedMessage`
- added type `OrderCustomFieldRemovedMessage`
- added type `OrderCustomTypeRemovedMessage`
- added type `OrderCustomTypeSetMessage`
- added type `BusinessUnitParentChangedMessagePayload`
- added type `OrderCustomFieldAddedMessagePayload`
- added type `OrderCustomFieldChangedMessagePayload`
- added type `OrderCustomFieldRemovedMessagePayload`
- added type `OrderCustomTypeRemovedMessagePayload`
- added type `OrderCustomTypeSetMessagePayload`
- added type `StagedOrderSetDirectDiscountsAction`
- added type `StagedOrderSetStoreAction`
</details>


<details>
<summary>Deprecated Type(s)</summary>

- type `AssociateRoleDeprecated` is removed
- type `IndividualExclusionProductSelectionType` is removed
- type `IndividualProductSelectionType` is removed
- type `ProductSelectionType` is removed
- type `ProductSelectionTypeEnum` is removed
</details>


<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `CartSetDeliveryAddressCustomFieldAction`
- :warning: removed type `CartSetDeliveryAddressCustomTypeAction`
- :warning: removed type `BusinessUnitParentUnitChangedMessage`
- :warning: removed type `BusinessUnitParentUnitChangedMessagePayload`
- :warning: removed type `OrderResourceIdentifier`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().withKey().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().withKey().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().withKey().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().withId().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().withId().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().cartDiscounts().withId().delete()`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/in-store/key={storeKey}/cart-discounts`
- added resource `/{projectKey}/in-store/key={storeKey}/cart-discounts/key={key}`
- added resource `/{projectKey}/in-store/key={storeKey}/cart-discounts/{ID}`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `associate-role` to type `ChangeSubscriptionResourceTypeId`
</details>

**Import changes**

<details>
<summary>Required Property(s)</summary>

- :warning: changed property `key` of type `PriceDraftImport` to be required
- changed property `addresses` of type `CustomerImport` to be optional
</details>

**History changes**

<details>
<summary>Added Type(s)</summary>

- added type `AddInheritedAssociateChange`
- added type `AssociateRoleLabel`
- added type `ChangeBuyerAssignableChange`
- added type `ChangeInheritedAssociateChange`
- added type `InheritedAssociate`
- added type `InheritedAssociateRoleAssignment`
- added type `Permission`
- added type `RemoveInheritedAssociateChange`
- added type `SetLocalizedNameChange`
- added type `SetPermissionsChange`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `associate-role` to type `ChangeHistoryResourceType`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/8.1.0...9.0.0

# 8.1.0 (2023-07-03)

### Query predicate builders

This release introduces type safe builders for [query predicates](https://docs.commercetools.com/api/predicates/query). 
```
_projectApiRoot.Customers().Get()
    .WithQuery(q => q.FirstName().Is("Peter"));
```

Please see the [documentation](https://commercetools.github.io/commercetools-dotnet-core-sdk-v2/docs/html/d6/d45/md_docs_2_predicates.html) for details. More examples can be found in this [test class](https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/blob/master/commercetools.Sdk/Tests/commercetools.Sdk.Api.Tests/QueryTests.cs)

## What's Changed

* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/227
* Update SUNRISE data link in ME Endpoint Checkout App by @industrian in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/230
* add predicate builder extension methods by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/231
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/229
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/232
* move RAML extension to SDK by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/233
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/234
* remove webutility dependency by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/237
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/235

**Api changes**

<details>
<summary>Added Property(s)</summary>

- added property `key` to type `CustomLineItem`
- added property `perMethodTaxRate` to type `CustomLineItem`
- added property `key` to type `CustomLineItemDraft`
- added property `key` to type `LineItem`
- added property `key` to type `LineItemDraft`
- added property `key` to type `CartAddCustomLineItemAction`
- added property `key` to type `CartAddLineItemAction`
- added property `lineItemKey` to type `CartApplyDeltaToLineItemShippingDetailsTargetsAction`
- added property `lineItemKey` to type `CartChangeLineItemQuantityAction`
- added property `lineItemKey` to type `CartRemoveLineItemAction`
- added property `lineItemKey` to type `CartSetLineItemCustomFieldAction`
- added property `lineItemKey` to type `CartSetLineItemCustomTypeAction`
- added property `lineItemKey` to type `CartSetLineItemDistributionChannelAction`
- added property `lineItemKey` to type `CartSetLineItemInventoryModeAction`
- added property `lineItemKey` to type `CartSetLineItemPriceAction`
- added property `lineItemKey` to type `CartSetLineItemShippingDetailsAction`
- added property `lineItemKey` to type `CartSetLineItemSupplyChannelAction`
- added property `lineItemKey` to type `CartSetLineItemTaxAmountAction`
- added property `lineItemKey` to type `CartSetLineItemTaxRateAction`
- added property `lineItemKey` to type `CartSetLineItemTotalPriceAction`
- added property `key` to type `MyLineItemDraft`
- added property `key` to type `MyCartAddLineItemAction`
- added property `lineItemKey` to type `MyCartApplyDeltaToLineItemShippingDetailsTargetsAction`
- added property `lineItemKey` to type `MyCartChangeLineItemQuantityAction`
- added property `lineItemKey` to type `MyCartRemoveLineItemAction`
- added property `lineItemKey` to type `MyCartSetLineItemCustomFieldAction`
- added property `lineItemKey` to type `MyCartSetLineItemCustomTypeAction`
- added property `lineItemKey` to type `MyCartSetLineItemDistributionChannelAction`
- added property `lineItemKey` to type `MyCartSetLineItemShippingDetailsAction`
- added property `lineItemKey` to type `MyCartSetLineItemSupplyChannelAction`
- added property `lineItemKey` to type `MyShoppingListChangeLineItemQuantityAction`
- added property `sku` to type `StandalonePriceDeletedMessage`
- added property `sku` to type `StandalonePriceDeletedMessagePayload`
- added property `key` to type `StagedOrderAddCustomLineItemAction`
- added property `key` to type `StagedOrderAddLineItemAction`
- added property `parcelKey` to type `StagedOrderAddParcelToDeliveryAction`
- added property `lineItemKey` to type `StagedOrderChangeLineItemQuantityAction`
- added property `lineItemKey` to type `StagedOrderRemoveLineItemAction`
- added property `parcelKey` to type `StagedOrderRemoveParcelFromDeliveryAction`
- added property `lineItemKey` to type `StagedOrderSetLineItemCustomFieldAction`
- added property `lineItemKey` to type `StagedOrderSetLineItemCustomTypeAction`
- added property `lineItemKey` to type `StagedOrderSetLineItemDistributionChannelAction`
- added property `lineItemKey` to type `StagedOrderSetLineItemPriceAction`
- added property `lineItemKey` to type `StagedOrderSetLineItemShippingDetailsAction`
- added property `lineItemKey` to type `StagedOrderSetLineItemTaxAmountAction`
- added property `lineItemKey` to type `StagedOrderSetLineItemTaxRateAction`
- added property `lineItemKey` to type `StagedOrderSetLineItemTotalPriceAction`
- added property `parcelKey` to type `StagedOrderSetParcelCustomFieldAction`
- added property `parcelKey` to type `StagedOrderSetParcelCustomTypeAction`
- added property `parcelKey` to type `StagedOrderSetParcelItemsAction`
- added property `parcelKey` to type `StagedOrderSetParcelMeasurementsAction`
- added property `parcelKey` to type `StagedOrderSetParcelTrackingDataAction`
- added property `key` to type `Parcel`
- added property `key` to type `ParcelDraft`
- added property `parcelKey` to type `OrderAddParcelToDeliveryAction`
- added property `parcelKey` to type `OrderRemoveParcelFromDeliveryAction`
- added property `lineItemKey` to type `OrderSetLineItemCustomFieldAction`
- added property `lineItemKey` to type `OrderSetLineItemCustomTypeAction`
- added property `lineItemKey` to type `OrderSetLineItemShippingDetailsAction`
- added property `parcelKey` to type `OrderSetParcelCustomFieldAction`
- added property `parcelKey` to type `OrderSetParcelCustomTypeAction`
- added property `parcelKey` to type `OrderSetParcelItemsAction`
- added property `parcelKey` to type `OrderSetParcelMeasurementsAction`
- added property `parcelKey` to type `OrderSetParcelTrackingDataAction`
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `lineItemId` of type `CartApplyDeltaToLineItemShippingDetailsTargetsAction` to be optional
- changed property `lineItemId` of type `CartChangeLineItemQuantityAction` to be optional
- changed property `lineItemId` of type `CartRemoveLineItemAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemCustomFieldAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemCustomTypeAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemDistributionChannelAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemInventoryModeAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemPriceAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemShippingDetailsAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemSupplyChannelAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemTaxAmountAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemTaxRateAction` to be optional
- changed property `lineItemId` of type `CartSetLineItemTotalPriceAction` to be optional
- changed property `lineItemId` of type `MyCartApplyDeltaToLineItemShippingDetailsTargetsAction` to be optional
- changed property `lineItemId` of type `MyCartChangeLineItemQuantityAction` to be optional
- changed property `lineItemId` of type `MyCartRemoveLineItemAction` to be optional
- changed property `lineItemId` of type `MyCartSetLineItemCustomFieldAction` to be optional
- changed property `lineItemId` of type `MyCartSetLineItemCustomTypeAction` to be optional
- changed property `lineItemId` of type `MyCartSetLineItemDistributionChannelAction` to be optional
- changed property `lineItemId` of type `MyCartSetLineItemShippingDetailsAction` to be optional
- changed property `lineItemId` of type `MyCartSetLineItemSupplyChannelAction` to be optional
- changed property `lineItemId` of type `MyShoppingListChangeLineItemQuantityAction` to be optional
- changed property `lineItemId` of type `StagedOrderChangeLineItemQuantityAction` to be optional
- changed property `lineItemId` of type `StagedOrderRemoveLineItemAction` to be optional
- changed property `parcelId` of type `StagedOrderRemoveParcelFromDeliveryAction` to be optional
- changed property `lineItemId` of type `StagedOrderSetLineItemCustomFieldAction` to be optional
- changed property `lineItemId` of type `StagedOrderSetLineItemCustomTypeAction` to be optional
- changed property `lineItemId` of type `StagedOrderSetLineItemDistributionChannelAction` to be optional
- changed property `lineItemId` of type `StagedOrderSetLineItemPriceAction` to be optional
- changed property `lineItemId` of type `StagedOrderSetLineItemShippingDetailsAction` to be optional
- changed property `lineItemId` of type `StagedOrderSetLineItemTaxAmountAction` to be optional
- changed property `lineItemId` of type `StagedOrderSetLineItemTaxRateAction` to be optional
- changed property `lineItemId` of type `StagedOrderSetLineItemTotalPriceAction` to be optional
- changed property `parcelId` of type `StagedOrderSetParcelCustomFieldAction` to be optional
- changed property `parcelId` of type `StagedOrderSetParcelCustomTypeAction` to be optional
- changed property `parcelId` of type `StagedOrderSetParcelItemsAction` to be optional
- changed property `parcelId` of type `StagedOrderSetParcelMeasurementsAction` to be optional
- changed property `parcelId` of type `StagedOrderSetParcelTrackingDataAction` to be optional
- changed property `parcelId` of type `OrderRemoveParcelFromDeliveryAction` to be optional
- changed property `lineItemId` of type `OrderSetLineItemCustomFieldAction` to be optional
- changed property `lineItemId` of type `OrderSetLineItemCustomTypeAction` to be optional
- changed property `lineItemId` of type `OrderSetLineItemShippingDetailsAction` to be optional
- changed property `parcelId` of type `OrderSetParcelCustomFieldAction` to be optional
- changed property `parcelId` of type `OrderSetParcelCustomTypeAction` to be optional
- changed property `parcelId` of type `OrderSetParcelItemsAction` to be optional
- changed property `parcelId` of type `OrderSetParcelMeasurementsAction` to be optional
- changed property `parcelId` of type `OrderSetParcelTrackingDataAction` to be optional
</details>


<details>
<summary>Deprecated Property(s)</summary>

- property `MyCartChangeLineItemQuantityAction::externalPrice` is removed
- property `MyCartChangeLineItemQuantityAction::externalTotalPrice` is removed
</details>


<details>
<summary>Deprecated Type(s)</summary>

- type `ProductVariantSelectionExclusion` is removed
- type `ProductVariantSelectionInclusion` is removed
</details>


<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `MyCartSetDirectDiscountsAction`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `StandalonePriceTierAddedMessage`
- added type `StandalonePriceTierRemovedMessage`
- added type `StandalonePriceTiersSetMessage`
- added type `StandalonePriceValidFromAndUntilSetMessage`
- added type `StandalonePriceValidFromSetMessage`
- added type `StandalonePriceValidUntilSetMessage`
- added type `StandalonePriceTierAddedMessagePayload`
- added type `StandalonePriceTierRemovedMessagePayload`
- added type `StandalonePriceTiersSetMessagePayload`
- added type `StandalonePriceValidFromAndUntilSetMessagePayload`
- added type `StandalonePriceValidFromSetMessagePayload`
- added type `StandalonePriceValidUntilSetMessagePayload`
- added type `StandalonePriceAddPriceTierAction`
- added type `StandalonePriceRemovePriceTierAction`
- added type `StandalonePriceSetPriceTiersAction`
- added type `StandalonePriceSetValidFromAction`
- added type `StandalonePriceSetValidFromAndUntilAction`
- added type `StandalonePriceSetValidUntilAction`
- added type `ConfluentCloudDestination`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `associate-role` to type `CustomFieldReferenceValue`
- added enum `business-unit` to type `CustomFieldReferenceValue`
</details>

**Import changes**

<details>
<summary>Added Enum(s)</summary>

- added enum `associate-role` to type `CustomFieldReferenceValue`
- added enum `business-unit` to type `CustomFieldReferenceValue`
</details>

**History changes**

<details>
<summary>Added Property(s)</summary>

- added property `variantSelection` to type `AddProductChange`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `resource` of type `Record` from type `Reference` to `ResourceIdentifier`
</details>


<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `resourceKey` to method `get /{projectKey}`
- added query parameter `resourceKey` to method `get /{projectKey}/{resourceType}`
</details>


<details>
<summary>Removed QueryParameter(s)</summary>

- :warning: removed query parameter `resourceId` from method `get /{projectKey}/{resourceType}`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `AddAssociateChange`
- added type `AddProductSelectionChange`
- added type `Associate`
- added type `AssociateRoleAssignment`
- added type `AssociateRoleInheritanceMode`
- added type `BusinessUnitAssociateMode`
- added type `BusinessUnitLabel`
- added type `BusinessUnitStatus`
- added type `BusinessUnitStoreMode`
- added type `ChangeAssociateChange`
- added type `ChangeAssociateModeChange`
- added type `ChangeParentUnitChange`
- added type `ChangeProductSelectionActiveChange`
- added type `ChangeStatusChange`
- added type `ProductVariantSelection`
- added type `ProductVariantSelectionTypeEnum`
- added type `RemoveAssociateChange`
- added type `RemoveProductSelectionChange`
- added type `RequestQuoteRenegotiationChange`
- added type `ResourceIdentifier`
- added type `SetAddressCustomFieldChange`
- added type `SetAddressCustomTypeChange`
- added type `SetContactEmailChange`
- added type `SetStoreModeChange`
- added type `SetVariantSelectionChange`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `business-unit` to type `ChangeHistoryResourceType`
- added enum `addAssociate` to type `UpdateType`
- added enum `addCustomLineItem` to type `UpdateType`
- added enum `addDiscountCode` to type `UpdateType`
- added enum `addProduct` to type `UpdateType`
- added enum `addProductSelection` to type `UpdateType`
- added enum `addProperty` to type `UpdateType`
- added enum `changeAmountAuthorized` to type `UpdateType`
- added enum `changeAssociate` to type `UpdateType`
- added enum `changeAssociateMode` to type `UpdateType`
- added enum `changeCustomLineItemQuantity` to type `UpdateType`
- added enum `changeLineItemName` to type `UpdateType`
- added enum `changeParentUnit` to type `UpdateType`
- added enum `changeProductSelectionActive` to type `UpdateType`
- added enum `changeQuoteRequestState` to type `UpdateType`
- added enum `changeQuoteState` to type `UpdateType`
- added enum `changeStagedQuoteState` to type `UpdateType`
- added enum `changeStatus` to type `UpdateType`
- added enum `changeTaxCalculationMode` to type `UpdateType`
- added enum `changeTaxMode` to type `UpdateType`
- added enum `changeTaxRoundingMode` to type `UpdateType`
- added enum `moveImageToPosition` to type `UpdateType`
- added enum `removeAssociate` to type `UpdateType`
- added enum `removeCustomLineItem` to type `UpdateType`
- added enum `removeDiscountCode` to type `UpdateType`
- added enum `removeProduct` to type `UpdateType`
- added enum `removeProductSelection` to type `UpdateType`
- added enum `removeProperty` to type `UpdateType`
- added enum `requestQuoteRenegotiation` to type `UpdateType`
- added enum `setAddressCustomField` to type `UpdateType`
- added enum `setAddressCustomType` to type `UpdateType`
- added enum `setApplicationVersion` to type `UpdateType`
- added enum `setAuthenticationMode` to type `UpdateType`
- added enum `setContactEmail` to type `UpdateType`
- added enum `setCountries` to type `UpdateType`
- added enum `setCountry` to type `UpdateType`
- added enum `setCustomLineItemMoney` to type `UpdateType`
- added enum `setCustomLineItemTaxAmount` to type `UpdateType`
- added enum `setCustomLineItemTaxCategory` to type `UpdateType`
- added enum `setCustomLineItemTaxRate` to type `UpdateType`
- added enum `setCustomLineItemTaxedPrice` to type `UpdateType`
- added enum `setCustomLineItemTotalPrice` to type `UpdateType`
- added enum `setCustomShippingMethod` to type `UpdateType`
- added enum `setIsValid` to type `UpdateType`
- added enum `setLineItemDeactivatedAt` to type `UpdateType`
- added enum `setLineItemDiscountedPrice` to type `UpdateType`
- added enum `setLineItemDiscountedPricePerQuantity` to type `UpdateType`
- added enum `setLineItemDistributionChannel` to type `UpdateType`
- added enum `setLineItemPrice` to type `UpdateType`
- added enum `setLineItemProductKey` to type `UpdateType`
- added enum `setLineItemProductSlug` to type `UpdateType`
- added enum `setLineItemTaxAmount` to type `UpdateType`
- added enum `setLineItemTaxRate` to type `UpdateType`
- added enum `setLineItemTaxedPrice` to type `UpdateType`
- added enum `setLineItemTotalPrice` to type `UpdateType`
- added enum `setOrderTaxedPrice` to type `UpdateType`
- added enum `setOrderTotalPrice` to type `UpdateType`
- added enum `setOrderTotalTax` to type `UpdateType`
- added enum `setPrices` to type `UpdateType`
- added enum `setProductCount` to type `UpdateType`
- added enum `setProductSelections` to type `UpdateType`
- added enum `setProperty` to type `UpdateType`
- added enum `setPurchaseOrderNumber` to type `UpdateType`
- added enum `setReservations` to type `UpdateType`
- added enum `setSellerComment` to type `UpdateType`
- added enum `setShippingInfoPrice` to type `UpdateType`
- added enum `setShippingInfoTaxedPrice` to type `UpdateType`
- added enum `setShippingMethod` to type `UpdateType`
- added enum `setShippingMethodTaxAmount` to type `UpdateType`
- added enum `setShippingMethodTaxRate` to type `UpdateType`
- added enum `setShippingRate` to type `UpdateType`
- added enum `setShippingRateInput` to type `UpdateType`
- added enum `setStoreMode` to type `UpdateType`
- added enum `setSupplyChannels` to type `UpdateType`
- added enum `setValidTo` to type `UpdateType`
- added enum `setValue` to type `UpdateType`
- added enum `setVariantSelection` to type `UpdateType`
- added enum `DeclinedForRenegotiation` to type `QuoteState`
- added enum `associate-role` to type `ReferenceTypeId`
- added enum `business-unit` to type `ReferenceTypeId`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/8.0.0...8.1.0

# 8.0.0 (2023-06-05)

## New Feature

The TokenProvider has been refactored and returns a Token promise. The OAuth middleware expects a TokenProvider to have a Method returning a Token promise. For Backwards compatibility the Token property has been adjusted to facilitate the asynchronous methods, but has been declared obsolote. This may affect implementations of a custom TokenProvider.

## What's Changed
* add serializer interfaces for different APIs by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/224
* refactor token provider to use token promise to avoid long locks by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/225
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/222
* Subscription example by @barbara79 in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/223

**Api changes**

<details>
<summary>Added Property(s)</summary>

- added property `shippingKey` to type `CartSetShippingMethodTaxAmountAction`
- added property `shippingKey` to type `CartSetShippingMethodTaxRateAction`
- added property `associateRoleAssignments` to type `MyBusinessUnitAssociateDraft`
- added property `deliveryKey` to type `StagedOrderAddDeliveryAction`
- added property `deliveryKey` to type `StagedOrderAddParcelToDeliveryAction`
- added property `deliveryKey` to type `StagedOrderRemoveDeliveryAction`
- added property `deliveryKey` to type `StagedOrderSetDeliveryAddressAction`
- added property `deliveryKey` to type `StagedOrderSetDeliveryAddressCustomFieldAction`
- added property `deliveryKey` to type `StagedOrderSetDeliveryAddressCustomTypeAction`
- added property `deliveryKey` to type `StagedOrderSetDeliveryCustomFieldAction`
- added property `deliveryKey` to type `StagedOrderSetDeliveryCustomTypeAction`
- added property `deliveryKey` to type `StagedOrderSetDeliveryItemsAction`
- added property `shippingKey` to type `StagedOrderSetShippingMethodTaxAmountAction`
- added property `shippingKey` to type `StagedOrderSetShippingMethodTaxRateAction`
- added property `key` to type `Delivery`
- added property `key` to type `DeliveryDraft`
- added property `deliveryKey` to type `OrderAddDeliveryAction`
- added property `deliveryKey` to type `OrderAddParcelToDeliveryAction`
- added property `deliveryKey` to type `OrderRemoveDeliveryAction`
- added property `deliveryKey` to type `OrderSetDeliveryAddressAction`
- added property `deliveryKey` to type `OrderSetDeliveryAddressCustomFieldAction`
- added property `deliveryKey` to type `OrderSetDeliveryAddressCustomTypeAction`
- added property `deliveryKey` to type `OrderSetDeliveryCustomFieldAction`
- added property `deliveryKey` to type `OrderSetDeliveryCustomTypeAction`
- added property `deliveryKey` to type `OrderSetDeliveryItemsAction`
- added property `sku` to type `ProductRemovePriceAction`
- added property `variantId` to type `ProductRemovePriceAction`
- added property `price` to type `ProductRemovePriceAction`
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `deliveryId` of type `StagedOrderAddParcelToDeliveryAction` to be optional
- changed property `deliveryId` of type `StagedOrderRemoveDeliveryAction` to be optional
- changed property `deliveryId` of type `StagedOrderSetDeliveryAddressAction` to be optional
- changed property `deliveryId` of type `StagedOrderSetDeliveryAddressCustomFieldAction` to be optional
- changed property `deliveryId` of type `StagedOrderSetDeliveryAddressCustomTypeAction` to be optional
- changed property `deliveryId` of type `StagedOrderSetDeliveryCustomFieldAction` to be optional
- changed property `deliveryId` of type `StagedOrderSetDeliveryCustomTypeAction` to be optional
- changed property `deliveryId` of type `StagedOrderSetDeliveryItemsAction` to be optional
- changed property `deliveryId` of type `OrderAddParcelToDeliveryAction` to be optional
- changed property `deliveryId` of type `OrderRemoveDeliveryAction` to be optional
- changed property `deliveryId` of type `OrderSetDeliveryAddressAction` to be optional
- changed property `deliveryId` of type `OrderSetDeliveryAddressCustomFieldAction` to be optional
- changed property `deliveryId` of type `OrderSetDeliveryAddressCustomTypeAction` to be optional
- changed property `deliveryId` of type `OrderSetDeliveryCustomFieldAction` to be optional
- changed property `deliveryId` of type `OrderSetDeliveryCustomTypeAction` to be optional
- changed property `deliveryId` of type `OrderSetDeliveryItemsAction` to be optional
</details>


<details>
<summary>Added Type(s)</summary>

- added type `CartSetLineItemInventoryModeAction`
- added type `AssociateMissingPermissionError`
- added type `MoneyOverflowError`
- added type `GraphQLAssociateMissingPermissionError`
- added type `GraphQLMoneyOverflowError`
- added type `MyCartSetDirectDiscountsAction`
- added type `QuoteCustomerChangedMessage`
- added type `QuoteRequestCustomerChangedMessage`
- added type `QuoteCustomerChangedMessagePayload`
- added type `QuoteRequestCustomerChangedMessagePayload`
- added type `QuoteRequestChangeCustomerAction`
- added type `QuoteChangeCustomerAction`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/carts/replicate`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `ReassignMyQuotes` to type `Permission`
- added enum `ReassignOthersQuotes` to type `Permission`
- added enum `RenegotiationAddressed` to type `QuoteState`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().replicate().post()`
</details>

**Import changes**

<details>
<summary>Added Type(s)</summary>

- added type `TypeImportRequest`
- added type `TypeTextInputHint`
- added type `ResourceTypeId`
- added type `FieldType`
- added type `CustomFieldBooleanType`
- added type `CustomFieldDateTimeType`
- added type `CustomFieldDateType`
- added type `CustomFieldEnumType`
- added type `CustomFieldEnumValue`
- added type `CustomFieldLocalizedEnumType`
- added type `CustomFieldLocalizedEnumValue`
- added type `CustomFieldLocalizedStringType`
- added type `CustomFieldMoneyType`
- added type `CustomFieldNumberType`
- added type `CustomFieldReferenceType`
- added type `CustomFieldReferenceValue`
- added type `CustomFieldSetType`
- added type `CustomFieldStringType`
- added type `CustomFieldTimeType`
- added type `FieldDefinition`
- added type `TypeImport`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/types`
- added resource `/{projectKey}/types/import-containers`
- added resource `/{projectKey}/types/import-containers/{importContainerKey}`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `type` to type `ImportResourceType`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKeyValue().types().importContainers().withImportContainerKeyValue().post()`
</details>

**History changes**

<details>
<summary>Added Type(s)</summary>

- added type `SetCountriesChange`
- added type `SetPurchaseOrderNumberChange`
- added type `StoreCountry`
</details>


<details>
<summary>Removed QueryParameter(s)</summary>

- :warning: removed query parameter `resourceType` from method `get /{projectKey}`
</details>


<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `resourceTypes` to method `get /{projectKey}`
</details>

## New Contributors
* @barbara79 made their first contribution in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/223

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/7.4.0...8.0.0

# 7.4.0 (2023-05-08)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/219
**Api changes**

<details>
<summary>Changed Type(s)</summary>

- :warning: changed type `AssociateRole` from type `string` to `BaseResource`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `AssociateRoleDraft`
- added type `AssociateRoleKeyReference`
- added type `AssociateRolePagedQueryResponse`
- added type `AssociateRoleReference`
- added type `AssociateRoleResourceIdentifier`
- added type `AssociateRoleUpdate`
- added type `AssociateRoleUpdateAction`
- added type `Permission`
- added type `AssociateRoleAddPermissionAction`
- added type `AssociateRoleChangeBuyerAssignableAction`
- added type `AssociateRoleRemovePermissionAction`
- added type `AssociateRoleSetCustomFieldAction`
- added type `AssociateRoleSetCustomTypeAction`
- added type `AssociateRoleSetNameAction`
- added type `AssociateRoleSetPermissionsAction`
- added type `AssociateRoleAssignment`
- added type `AssociateRoleAssignmentDraft`
- added type `AssociateRoleDeprecated`
- added type `AssociateRoleInheritanceMode`
- added type `BusinessUnitAssociateMode`
- added type `InheritedAssociate`
- added type `InheritedAssociateRoleAssignment`
- added type `BusinessUnitChangeAssociateModeAction`
- added type `AssociateRoleBuyerAssignableChangedMessage`
- added type `AssociateRoleCreatedMessage`
- added type `AssociateRoleDeletedMessage`
- added type `AssociateRoleNameChangedMessage`
- added type `AssociateRolePermissionAddedMessage`
- added type `AssociateRolePermissionRemovedMessage`
- added type `AssociateRolePermissionsSetMessage`
- added type `BusinessUnitAssociateModeChangedMessage`
- added type `AssociateRoleBuyerAssignableChangedMessagePayload`
- added type `AssociateRoleCreatedMessagePayload`
- added type `AssociateRoleDeletedMessagePayload`
- added type `AssociateRoleNameChangedMessagePayload`
- added type `AssociateRolePermissionAddedMessagePayload`
- added type `AssociateRolePermissionRemovedMessagePayload`
- added type `AssociateRolePermissionsSetMessagePayload`
- added type `BusinessUnitAssociateModeChangedMessagePayload`
- added type `ProjectSetBusinessUnitAssociateRoleOnCreationAction`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `associate-role` to type `ReferenceTypeId`
- added enum `associate-role` to type `MessageSubscriptionResourceTypeId`
- added enum `associate-role` to type `ResourceTypeId`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `associateRoleAssignments` to type `Associate`
- added property `associateRoleAssignments` to type `AssociateDraft`
- added property `associateMode` to type `BusinessUnit`
- added property `inheritedAssociates` to type `BusinessUnit`
- added property `associateMode` to type `BusinessUnitDraft`
- added property `associateMode` to type `Company`
- added property `inheritedAssociates` to type `Company`
- added property `associateMode` to type `CompanyDraft`
- added property `associateMode` to type `Division`
- added property `inheritedAssociates` to type `Division`
- added property `associateMode` to type `DivisionDraft`
- added property `myBusinessUnitAssociateRoleOnCreation` to type `BusinessUnitConfiguration`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `roles` of type `Associate` from type `AssociateRole[]` to `AssociateRoleDeprecated[]`
- :warning: changed property `roles` of type `AssociateDraft` from type `AssociateRole[]` to `AssociateRoleDeprecated[]`
</details>


<details>
<summary>MarkDeprecated Property(s)</summary>

- marked property `Associate::roles` as deprecated
- marked property `AssociateDraft::roles` as deprecated
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/as-associate`
- added resource `/{projectKey}/associate-roles`
- added resource `/{projectKey}/as-associate/{associateId}`
- added resource `/{projectKey}/as-associate/{associateId}/business-units`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}`
- added resource `/{projectKey}/as-associate/{associateId}/business-units/key={key}`
- added resource `/{projectKey}/as-associate/{associateId}/business-units/{ID}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/carts`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/orders`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/quotes`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/quote-requests`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/carts/key={key}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/carts/{ID}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/orders/quotes`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/orders/order-number={orderNumber}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/orders/{ID}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/quotes/key={key}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/quotes/{ID}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/quote-requests/key={key}`
- added resource `/{projectKey}/as-associate/{associateId}/in-business-unit/key={businessUnitKey}/quote-requests/{ID}`
- added resource `/{projectKey}/associate-roles/key={key}`
- added resource `/{projectKey}/associate-roles/{ID}`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().associateRoles().get()`
- added method `apiRoot.withProjectKey().associateRoles().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().businessUnits().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().businessUnits().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().businessUnits().withKey().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().businessUnits().withKey().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().businessUnits().withId().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().businessUnits().withId().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quotes().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quoteRequests().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quoteRequests().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().withKey().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().withKey().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().withKey().delete()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().withId().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().withId().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().carts().withId().delete()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().orderQuote().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().withOrderNumber().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().withOrderNumber().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().withId().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().orders().withId().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quotes().withKey().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quotes().withKey().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quotes().withId().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quotes().withId().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quoteRequests().withKey().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quoteRequests().withKey().post()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quoteRequests().withId().get()`
- added method `apiRoot.withProjectKey().asAssociate().withAssociateIdValue().inBusinessUnitKeyWithBusinessUnitKeyValue().quoteRequests().withId().post()`
- added method `apiRoot.withProjectKey().associateRoles().withKey().get()`
- added method `apiRoot.withProjectKey().associateRoles().withKey().post()`
- added method `apiRoot.withProjectKey().associateRoles().withKey().delete()`
- added method `apiRoot.withProjectKey().associateRoles().withId().get()`
- added method `apiRoot.withProjectKey().associateRoles().withId().post()`
- added method `apiRoot.withProjectKey().associateRoles().withId().delete()`
</details>

**History changes**

<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `resourceTypes` to method `get /{projectKey}`
</details>


<details>
<summary>Removed QueryParameter(s)</summary>

- :warning: removed query parameter `resourceType` from method `get /{projectKey}`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `SetCountriesChange`
- added type `SetPurchaseOrderNumberChange`
- added type `StoreCountry`
</details>

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/7.3.0...7.4.0

# 7.3.0 (2023-05-02)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/218

**Api changes**

<details>
<summary>Added Enum(s)</summary>

- added enum `direct-discount` to type `ReferenceTypeId`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `field` to type `OrderSearchSorting`
- added property `language` to type `OrderSearchSorting`
- added property `order` to type `OrderSearchSorting`
- added property `mode` to type `OrderSearchSorting`
- added property `filter` to type `OrderSearchSorting`
- added property `mode` to type `ProductSelection`
- added property `mode` to type `ProductSelectionDraft`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `discount` of type `DiscountedLineItemPortion` from type `CartDiscountReference` to `Reference`
- :warning: changed property `productSelection` of type `ProductSelectionCreatedMessage` from type `ProductSelectionType` to `ProductSelection`
- :warning: changed property `productSelection` of type `ProductSelectionCreatedMessagePayload` from type `ProductSelectionType` to `ProductSelection`
</details>


<details>
<summary>MarkDeprecated Property(s)</summary>

- marked property `IndividualExclusionProductSelectionType::type` as deprecated
- marked property `IndividualProductSelectionType::type` as deprecated
- marked property `ProductSelection::type` as deprecated
- marked property `ProductSelectionDraft::type` as deprecated
- marked property `ProductSelectionType::type` as deprecated
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `type` of type `ProductSelection` to be optional
</details>


<details>
<summary>MarkDeprecated Type(s)</summary>

- marked type `IndividualExclusionProductSelectionType` as deprecated
- marked type `IndividualProductSelectionType` as deprecated
- marked type `ProductSelectionType` as deprecated
- marked type `ProductSelectionTypeEnum` as deprecated
</details>


<details>
<summary>Added Type(s)</summary>

- added type `DirectDiscountReference`
- added type `OrderSearchAndExpression`
- added type `OrderSearchAnyValue`
- added type `OrderSearchCompoundExpression`
- added type `OrderSearchDateRangeExpression`
- added type `OrderSearchDateRangeValue`
- added type `OrderSearchExactExpression`
- added type `OrderSearchExistsExpression`
- added type `OrderSearchFilterExpression`
- added type `OrderSearchFullTextExpression`
- added type `OrderSearchFullTextValue`
- added type `OrderSearchLongRangeExpression`
- added type `OrderSearchLongRangeValue`
- added type `OrderSearchMatchType`
- added type `OrderSearchNotExpression`
- added type `OrderSearchNumberRangeExpression`
- added type `OrderSearchNumberRangeValue`
- added type `OrderSearchOrExpression`
- added type `OrderSearchPrefixExpression`
- added type `OrderSearchQueryExpression`
- added type `OrderSearchQueryExpressionValue`
- added type `OrderSearchSortMode`
- added type `OrderSearchSortOrder`
- added type `OrderSearchStringValue`
- added type `OrderSearchWildCardExpression`
- added type `ProductSelectionMode`
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/7.2.0...7.3.0

# 7.2.0 (2023-04-13)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/217

**Api changes**

<details>
<summary>Added Property(s)</summary>

- added property `shippingKey` to type `Cart`
- added property `shippingCustomFields` to type `Cart`
- added property `shippingKey` to type `StagedOrder`
- added property `shippingCustomFields` to type `StagedOrder`
- added property `shippingKey` to type `Order`
- added property `shippingCustomFields` to type `Order`
- added property `key` to type `TaxRate`
- added property `key` to type `TaxRateDraft`
- added property `taxRateKey` to type `TaxCategoryRemoveTaxRateAction`
- added property `taxRateKey` to type `TaxCategoryReplaceTaxRateAction`
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `taxRateId` of type `TaxCategoryRemoveTaxRateAction` to be optional
- changed property `taxRateId` of type `TaxCategoryReplaceTaxRateAction` to be optional
</details>


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/7.1.0...7.2.0

# 7.1.0 (2023-04-03)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/216


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/7.0.0...7.1.0

# 7.0.0 (2023-03-06)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/214


**Api changes**

<details>
<summary>Removed Property(s)</summary>

- :warning: removed property `externalTaxRate` from type `MyCartAddLineItemAction`
- :warning: removed property `externalPrice` from type `MyCartAddLineItemAction`
- :warning: removed property `externalTotalPrice` from type `MyCartAddLineItemAction`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `totalPrice` of type `Cart` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `totalPrice` of type `CustomLineItem` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `externalTaxRate` of type `CustomShippingDraft` from type `string` to `ExternalTaxRateDraft`
- :warning: changed property `deliveries` of type `CustomShippingDraft` from type `Delivery[]` to `DeliveryDraft[]`
- :warning: changed property `custom` of type `CustomShippingDraft` from type `string` to `CustomFieldsDraft`
- :warning: changed property `country` of type `ExternalTaxRateDraft` from type `string` to `CountryCode`
- :warning: changed property `totalPrice` of type `LineItem` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `externalTaxRate` of type `ShippingDraft` from type `string` to `ExternalTaxRateDraft`
- :warning: changed property `deliveries` of type `ShippingDraft` from type `Delivery[]` to `DeliveryDraft[]`
- :warning: changed property `custom` of type `ShippingDraft` from type `string` to `CustomFieldsDraft`
- :warning: changed property `price` of type `ShippingInfo` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `amount` of type `TaxPortion` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `totalNet` of type `TaxedItemPrice` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `totalGross` of type `TaxedItemPrice` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `totalTax` of type `TaxedItemPrice` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `totalNet` of type `TaxedPrice` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `totalGross` of type `TaxedPrice` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `totalTax` of type `TaxedPrice` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `externalTaxRate` of type `CartAddCustomShippingMethodAction` from type `string` to `ExternalTaxRateDraft`
- :warning: changed property `deliveries` of type `CartAddCustomShippingMethodAction` from type `Delivery[]` to `DeliveryDraft[]`
- :warning: changed property `custom` of type `CartAddCustomShippingMethodAction` from type `string` to `CustomFieldsDraft`
- :warning: changed property `shippingMethod` of type `CartAddShippingMethodAction` from type `ShippingMethodReference` to `ShippingMethodResourceIdentifier`
- :warning: changed property `externalTaxRate` of type `CartAddShippingMethodAction` from type `string` to `ExternalTaxRateDraft`
- :warning: changed property `deliveries` of type `CartAddShippingMethodAction` from type `Delivery[]` to `DeliveryDraft[]`
- :warning: changed property `custom` of type `CartAddShippingMethodAction` from type `string` to `CustomFieldsDraft`
- :warning: changed property `businessUnit` of type `MyCartDraft` from type `BusinessUnitKeyReference` to `BusinessUnitResourceIdentifier`
- :warning: changed property `store` of type `MyCartDraft` from type `StoreKeyReference` to `StoreResourceIdentifier`
</details>


<details>
<summary>Required Property(s)</summary>

- :warning: changed property `inventoryMode` of type `Cart` to be required
- :warning: changed property `itemShippingAddresses` of type `Cart` to be required
- :warning: changed property `discountCodes` of type `Cart` to be required
- :warning: changed property `directDiscounts` of type `Cart` to be required
- :warning: changed property `shippingAddress` of type `ShippingDraft` to be required
- changed property `quantity` of type `CustomLineItemDraft` to be optional
- changed property `deliveries` of type `CustomShippingDraft` to be optional
- changed property `deliveries` of type `ShippingDraft` to be optional
- changed property `quantity` of type `CartAddCustomLineItemAction` to be optional
- changed property `deliveries` of type `CartAddCustomShippingMethodAction` to be optional
- changed property `deliveries` of type `CartAddShippingMethodAction` to be optional
- changed property `email` of type `CartSetCustomerEmailAction` to be optional
- changed property `quantity` of type `MyLineItemDraft` to be optional
</details>


<details>
<summary>Added Property(s)</summary>

- added property `shippingDetails` to type `CartAddCustomLineItemAction`
- added property `addedAt` to type `CartAddLineItemAction`
- added property `inventoryMode` to type `CartAddLineItemAction`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/me/orders/quotes`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().me().orders().quotes().post()`
</details>


<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `CountryNotConfiguredInStore`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `CartSetBusinessUnitAction`
- added type `CountryNotConfiguredInStoreError`
- added type `MyOrderFromQuoteDraft`
- added type `MyCartSetBusinessUnitAction`
</details>


<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `expand` to method `get /{projectKey}/in-store/key={storeKey}/me/active-cart`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `shipping` to type `ResourceTypeId`
</details>

**Import changes**

<details>
<summary>Required Property(s)</summary>

- changed property `password` of type `CustomerImport` to be optional
</details>


<details>
<summary>Added Property(s)</summary>

- added property `authenticationMode` to type `CustomerImport`
- added property `state` to type `OrderImport`
- added property `custom` to type `Address`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `AuthenticationMode`
</details>

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/6.4.0...7.0.0

# 6.4.0 (2023-02-20)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/211
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/213

**Api changes**

<details>
<summary>Added Type(s)</summary>

- added type `GoogleCloudFunctionDestination`
</details>

## Fixes

- fixed issue with DependencyInjection and usage of multiple clients which were incorrectly assigned to the ProjectApiRoots

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/6.3.1...6.4.0

# 6.3.1 (2023-02-17)

## What's Changed

* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/210

**Api changes**

<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `sort` to method `get /{projectKey}/product-selections/key={key}/products`
- added query parameter `sort` to method `get /{projectKey}/product-selections/{ID}/products`
</details>

### Fixes

- fix image upload without specifying a image name

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/6.3.0...6.3.1

# 6.3.0 (2023-02-16)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/207
* Add project scoped access to quotes, quoteRequests and stagedQuotes by @Tarostar in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/199

**Api changes**

<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `stores` of type `BusinessUnitDraft` from type `StoreKeyReference[]` to `StoreResourceIdentifier[]`
- :warning: changed property `stores` of type `CompanyDraft` from type `StoreKeyReference[]` to `StoreResourceIdentifier[]`
- :warning: changed property `stores` of type `DivisionDraft` from type `StoreKeyReference[]` to `StoreResourceIdentifier[]`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `oldValue` to type `StandalonePriceValueChangedMessage`
- added property `oldValue` to type `StandalonePriceValueChangedMessagePayload`
- added property `purchaseOrderNumber` to type `StagedOrder`
- added property `purchaseOrderNumber` to type `Order`
- added property `purchaseOrderNumber` to type `OrderFromCartDraft`
- added property `purchaseOrderNumber` to type `QuoteRequest`
- added property `purchaseOrderNumber` to type `QuoteRequestDraft`
- added property `purchaseOrderNumber` to type `Quote`
- added property `purchaseOrderNumber` to type `StagedQuote`
</details>


<details>
<summary>Deprecated Type(s)</summary>

- type `IronMqDestination` is removed
</details>


<details>
<summary>Added Type(s)</summary>

- added type `OrderPurchaseOrderNumberSetMessage`
- added type `OrderPurchaseOrderNumberSetMessagePayload`
- added type `StagedOrderSetPurchaseOrderNumberAction`
- added type `OrderSetPurchaseOrderNumberAction`
</details>


## New Contributors
* @Tarostar made their first contribution in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/199

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/6.2.0...6.3.0

# 6.2.0 (2023-02-10)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/202


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/6.1.0...6.2.0

# 6.1.0 (2023-01-10)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/198

**Api changes**

<details>
<summary>Added Enum(s)</summary>

- added enum `Frozen` to type `CartState`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/shipping-methods/matching-cart-location`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `amount` of type `Transaction` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `assets` of type `ProductAddVariantAction` from type `Asset[]` to `AssetDraft[]`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `defaultShippingAddressId` to type `BusinessUnit`
- added property `defaultShippingAddress` to type `BusinessUnitDraft`
- added property `defaultShippingAddressId` to type `Company`
- added property `defaultShippingAddress` to type `CompanyDraft`
- added property `defaultShippingAddressId` to type `Division`
- added property `defaultShippingAddress` to type `DivisionDraft`
- added property `conflictingPrice` to type `DuplicatePriceScopeError`
- added property `defaultShippingAddress` to type `MyBusinessUnitDraft`
- added property `defaultShippingAddress` to type `MyCompanyDraft`
- added property `defaultShippingAddress` to type `MyDivisionDraft`
- added property `cartId` to type `MyQuoteRequestDraft`
- added property `cartVersion` to type `MyQuoteRequestDraft`
- added property `createdAt` to type `AssignedProductSelection`
- added property `quoteState` to type `Quote`
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `discounted` of type `StagedStandalonePrice` to be optional
</details>


<details>
<summary>Removed Property(s)</summary>

- :warning: removed property `defaultShipingAddressId` from type `BusinessUnit`
- :warning: removed property `defaultShipingAddress` from type `BusinessUnitDraft`
- :warning: removed property `defaultShipingAddressId` from type `Company`
- :warning: removed property `defaultShipingAddress` from type `CompanyDraft`
- :warning: removed property `defaultShipingAddressId` from type `Division`
- :warning: removed property `defaultShipingAddress` from type `DivisionDraft`
- :warning: removed property `conflictingPrices` from type `DuplicatePriceScopeError`
- :warning: removed property `defaultShipingAddress` from type `MyBusinessUnitDraft`
- :warning: removed property `defaultShipingAddress` from type `MyCompanyDraft`
- :warning: removed property `defaultShipingAddress` from type `MyDivisionDraft`
- :warning: removed property `cart` from type `MyQuoteRequestDraft`
- :warning: removed property `version` from type `MyQuoteRequestDraft`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `CartFreezeCartAction`
- added type `CartUnfreezeCartAction`
- added type `DuplicatePriceKeyError`
- added type `ProductPriceKeySetMessage`
- added type `ProductPricesSetMessage`
- added type `StandalonePriceKeySetMessage`
- added type `ProductPriceKeySetMessagePayload`
- added type `ProductPricesSetMessagePayload`
- added type `StandalonePriceKeySetMessagePayload`
- added type `ProductSetPriceKeyAction`
- added type `StandalonePriceSetKeyAction`
</details>


<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `ProductPriceSetMessage`
- :warning: removed type `ProductPriceSetMessagePayload`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().shippingMethods().matchingCartLocation().get()`
</details>

**ML changes**

- Removed the `missing-data` endpoints and models due to low usage of the API.


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/6.0.0...6.1.0

# 6.0.0 (2022-12-06)

## What's Changed
* Add support for CancellationToken to requests
* added in models a setter for List properties of type IEnumerable remove the need to explicit casts
* fix fractionDigits for money factories by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/195
* license check with allowed licenses by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/192
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/191
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/196
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/197

### Breaking changes

- changed in models properties of type List to IList

### Generated Updates

**Api changes**

<details>
<summary>Added Property(s)</summary>

- added property `discountCodeId` to type `DiscountCodeNonApplicableError`
- added property `extensionErrors` to type `ExtensionBadResponseError`
- added property `extensionBody` to type `ExtensionBadResponseError`
- added property `extensionStatusCode` to type `ExtensionBadResponseError`
- added property `extensionId` to type `ExtensionBadResponseError`
- added property `extensionKey` to type `ExtensionBadResponseError`
- added property `extensionErrors` to type `ExtensionUpdateActionsFailedError`
- added property `detailedErrorMessage` to type `InvalidJsonInputError`
- added property `countries` to type `StoreCreatedMessage`
- added property `countries` to type `StoreCreatedMessagePayload`
- added property `priceMode` to type `ProductProjection`
- added property `countries` to type `Store`
- added property `countries` to type `StoreDraft`
</details>


<details>
<summary>Removed Property(s)</summary>

- :warning: removed property `dicountCodeId` from type `DiscountCodeNonApplicableError`
- :warning: removed property `conflictingResource` from type `DuplicateFieldError`
- :warning: removed property `error` from type `ErrorResponse`
- :warning: removed property `error_description` from type `ErrorResponse`
- :warning: removed property `errorByExtension` from type `ExtensionBadResponseError`
- :warning: removed property `errorByExtension` from type `ExtensionUpdateActionsFailedError`
</details>


<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `currency` of type `DuplicateStandalonePriceScopeError` from type `string` to `CurrencyCode`
- :warning: changed property `country` of type `DuplicateStandalonePriceScopeError` from type `string` to `CountryCode`
- :warning: changed property `currency` of type `MatchingPriceNotFoundError` from type `string` to `CurrencyCode`
- :warning: changed property `country` of type `MatchingPriceNotFoundError` from type `string` to `CountryCode`
- :warning: changed property `country` of type `MissingTaxRateForCountryError` from type `string` to `CountryCode`
- :warning: changed property `currency` of type `OverlappingStandalonePriceValidityError` from type `string` to `CurrencyCode`
- :warning: changed property `country` of type `OverlappingStandalonePriceValidityError` from type `string` to `CountryCode`
- :warning: changed property `amountPlanned` of type `MyPayment` from type `TypedMoney` to `CentPrecisionMoney`
- :warning: changed property `amountPlanned` of type `Payment` from type `TypedMoney` to `CentPrecisionMoney`
</details>


<details>
<summary>Required Property(s)</summary>

- :warning: changed property `field` of type `DuplicateFieldError` to be required
- :warning: changed property `duplicateValue` of type `DuplicateFieldError` to be required
- :warning: changed property `state` of type `Transaction` to be required
- :warning: changed property `lineItems` of type `ShoppingList` to be required
- :warning: changed property `textLineItems` of type `ShoppingList` to be required
</details>


<details>
<summary>Added Type(s)</summary>

- added type `AuthErrorResponse`
- added type `CountryNotConfiguredInStore`
- added type `ExtensionError`
- added type `ExtensionPredicateEvaluationFailedError`
- added type `ProductAssignmentMissingError`
- added type `ProductPresentWithDifferentVariantSelectionError`
- added type `ProductPriceAddedMessage`
- added type `ProductPriceChangedMessage`
- added type `ProductPriceModeSetMessage`
- added type `ProductPriceRemovedMessage`
- added type `ProductPriceSetMessage`
- added type `StoreCountriesChangedMessage`
- added type `ProductPriceAddedMessagePayload`
- added type `ProductPriceChangedMessagePayload`
- added type `ProductPriceModeSetMessagePayload`
- added type `ProductPriceRemovedMessagePayload`
- added type `ProductPriceSetMessagePayload`
- added type `StoreCountriesChangedMessagePayload`
- added type `StoreCountry`
- added type `StoreAddCountryAction`
- added type `StoreRemoveCountryAction`
- added type `StoreSetCountriesAction`
</details>


<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `AccessDeniedError`
- :warning: removed type `WeakPasswordError`
</details>


<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `localeProjection` to method `get /{projectKey}/products`
- added query parameter `localeProjection` to method `post /{projectKey}/products`
- added query parameter `localeProjection` to method `get /{projectKey}/products/key={key}`
- added query parameter `localeProjection` to method `post /{projectKey}/products/key={key}`
- added query parameter `localeProjection` to method `delete /{projectKey}/products/key={key}`
- added query parameter `localeProjection` to method `get /{projectKey}/products/{ID}`
- added query parameter `localeProjection` to method `post /{projectKey}/products/{ID}`
- added query parameter `localeProjection` to method `delete /{projectKey}/products/{ID}`
- added query parameter `staged` to method `get /{projectKey}/in-store/key={storeKey}/product-projections/key={key}`
- added query parameter `staged` to method `get /{projectKey}/in-store/key={storeKey}/product-projections/{ID}`
</details>



**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/5.3.0...6.0.0

# 5.3.0 (2022-11-07)

## What's Changed
* Add documentation for ME Endpoint App by @industrian in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/170
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/190

**Api changes**

<details>
<summary>Added Property(s)</summary>

- added property `shippingKey` to type `CartSetLineItemTaxAmountAction`
- added property `shippingKey` to type `CartSetLineItemTaxRateAction`
- added property `shippingKey` to type `StagedOrderSetLineItemTaxAmountAction`
- added property `shippingKey` to type `StagedOrderSetLineItemTaxRateAction`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `AttributeGroup`
- added type `AttributeGroupDraft`
- added type `AttributeGroupPagedQueryResponse`
- added type `AttributeGroupReference`
- added type `AttributeGroupResourceIdentifier`
- added type `AttributeGroupUpdate`
- added type `AttributeGroupUpdateAction`
- added type `AttributeReference`
- added type `AttributeGroupAddAttributeAction`
- added type `AttributeGroupChangeNameAction`
- added type `AttributeGroupRemoveAttributeAction`
- added type `AttributeGroupSetAttributesAction`
- added type `AttributeGroupSetDescriptionAction`
- added type `AttributeGroupSetKeyAction`
</details>


<details>
<summary>Changed Type(s)</summary>

- marked type `ShippingMethodSetDescriptionAction` as deprecated
</details>


<details>
<summary>Added Method(s)</summary>

- added method `get /{projectKey}/attribute-groups`
- added method `post /{projectKey}/attribute-groups`
- added method `get /{projectKey}/attribute-groups/key={key}`
- added method `post /{projectKey}/attribute-groups/key={key}`
- added method `delete /{projectKey}/attribute-groups/key={key}`
- added method `get /{projectKey}/attribute-groups/{ID}`
- added method `post /{projectKey}/attribute-groups/{ID}`
- added method `delete /{projectKey}/attribute-groups/{ID}`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/attribute-groups` (file:///home/runner/work/commercetools-api-reference/commercetools-api-reference/commercetools-api-reference/api-specs/api/api.raml:216:2)
- added resource `/{projectKey}/attribute-groups/key={key}`
- added resource `/{projectKey}/attribute-groups/{ID}`
</details>


## New Contributors
* @industrian made their first contribution in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/170

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/5.2.2...5.3.0

# 5.2.2 (2022-11-02)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/189

## Fixes

- fix wrongly placed obsolete attributes

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/5.2.1...5.2.2

# 5.2.1 (2022-11-01)

## Fixes

- remove obsolete marking from Destination types

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/5.2.0...5.2.1

# 5.2.0 (2022-11-01)

## What's Changed

* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/181

### Features

- support business unit
- support subscription health
- support embedded price `key`

### Fixes

- fix Me customer verify
- fix OrderSearchSorting to be an object

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/5.1.1...5.2.0

# 5.1.1 (2022-09-22)

## What's Changed
* Add project scoped access to product selections by @csi-lund in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/183

## New Contributors
* @csi-lund made their first contribution in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/183

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/5.1.0...5.1.1

# 5.1.0 (2022-09-16)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/180

### Features

- add standalone price to ResourceIdentifier
- support StagedStandalonePricing
- support Store name changes

### Fixes

- fix `money` field type for ProductDiscountValueAbsoluteDraft to `Money` 

### Deprecations

- ML services Missing Data endpoint has been deprecated

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/5.0.0...5.1.0

# 5.0.0 (2022-09-02)

## What's Changed
* fix serialization of dates and date times by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/179
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/173

### Features

- support Order Quotes
- support predicates for products head request
- support CustomLineItem priceMode
- support custom fields for customer address
- support cart custom shipping mode

### Fixes

- fix type of property `discountCodes` for MyCartDraft
- fix type of property `edit` for OrderEditAppliedMessage
- fix type of property `newTotalPrice` for OrderLineItemRemovedMessage
- fix type of property `productSelection` for ProductSelectionCreatedMessage
- add new Date struct to fix serialization of Date and DateTime values

### Breaking changes

- fix removed non existing property `name` from ProductSelectionDeletedMessage
- changed name of OrderReturnInfoAddedMessage to ReturnInfoAddedMessage
- changed name of OrderReturnInfoSetMessage to  ReturnInfoSetMessage

Please be aware that we introduced a new Date struct. This affects the `dateOfBirth` for customers and `lastUsedAt` for ApiClients. Also DateTime values are normalized to DateTimeKind.Utc when being deserialized.

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/4.2.0...5.0.0

# 4.2.0 (2022-08-30)

## Features

- UserAgent can be configured

## Fixes

- fix AmountToDecimal extension method to respect fractionDigits 

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/4.1.0...4.2.0

# 4.1.0 (2022-07-28)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/168
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/172

### Features

- add order custom lineitem messages
- add toDraft methods to Address, Parcel, Delivery
- add DeliveryDraft type
- support in store product selections
- support quotes
- support direct discounts for carts
- add LocaleprojectingTrait, StoreprojectingTrait
- quotes to extension resource types
- add factory methods for discriminating sub types

### Fixes

- fix type for field `version` in OrderEdit models
- fix type for field score in ScoreShippingRateInput & ScoreShippingRateInputDraft
Features
- OrderImport fix ShippingInfoImportDraft to use DeliveryDraft
- removed non existing endpoint in store product projections query
- removed `localeProjection` & `priceSelection` parameter from PriceselectingTrait as they are not applying to all endpoints using price selection

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/4.0.0...4.1.0

# 4.0.0 (2022-07-04)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/159
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/160

### Features:

- support `condition` for extension triggers
- support standalone pricing
- support in store product selections
- support quotes
- support DirectDiscounts for carts

### Fixes:

- fix customer email confirm request and response body type
- fix money types for CartDiscount read models
- fix type of `custom` field for CategorySetAssetCustomTypeAction
- removed wrong interfaces from ByProjectKeyInStoreKeyByStoreKeyProductProjectionsGet 
- fixed type of property score in `CartScoreTier` to `Integer` (was `Double`)

### Breaking changes

- deleted classes from removed API functionality
- type of `AttributeReferenceType` property `referenceTypeId` changed to  `AttributeReferenceTypeId`
- removed deprecated import sink endpoints and models from Import API SDK
- removed non existing endpoint in store product projections query

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/3.2.0...4.0.0

# 3.2.0 (2022-05-25)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/154
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/157
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/158


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/3.1.0...3.2.0

# 3.1.0 (2022-04-29)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/149
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/150
* improve handling of zero digit number attribute by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/153

### Fixes

* fix response type for product suggestion endpoint

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/3.0.2...3.1.0

# 3.0.2 (2022-04-12)

## What's Changed
* type fix from decimal to integer/long for quantity properties in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/148


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/3.0.1...3.0.2

# 3.0.1 (2022-04-12)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/147

### Breaking changes and fixes

* all double values have been changed to decimal for improved precision


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/3.0.0...3.0.1

# 3.0.0 (2022-04-11)

## What's Changed
* Checkout Example enhancements by @MicheleRezk in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/134
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/133
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/135
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/136
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/137
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/146
* fix namespaces by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/142 and https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/144

### Breaking changes

* Namespace fixes
  There had been a mix of different namespaces in the SDK packages. This affected the development of the SDK itself. In order to resolve these issues the namespaces have been aligned. It should be sufficient to search and replace occurrences of the former namespace.
  
  - `commercetools.Api.x` has been renamed to `commercetools.Sdk.Api.x`
  - `commercetools.ImportApi.x` has been renamed to `commercetools.Sdk.ImportApi.x`
  - `commercetools.MLApi.x` has been renamed to `commercetools.Sdk.MLApi.Api.x`
  - `commercetools.HistoryApi.x` has been renamed to `commercetools.Sdk.HistoryApi.x`

* The following classes have been renamed for aligning the documentation and SDK type naming: 
  **Package commercetools.Sdk.Api.Models.Extensions**
    
    ExtensionAWSLambdaDestination to AWSLambdaDestination
    ExtensionAuthorizationHeaderAuthentication to AuthorizationHeaderAuthentication
    ExtensionAzureFunctionsAuthentication to AzureFunctionsAuthentication
    ExtensionHttpDestination to HttpDestination
    ExtensionHttpDestinationAuthentication to HttpDestinationAuthentication
    
  **Package commercetools.Sdk.Api.Models.Messages**
    
    MessageConfiguration to MessagesConfiguration
    MessageConfigurationDraft to MessagesConfigurationDraft
    
  **Package commercetools.Sdk.Api.Models.Products**
    
    FacetResultRange to RangeFacetResult
    FacetResultTerm to TermFacetResult
    
  **Package commercetools.Sdk.Api.Models.Subscriptions**
    
    DeliveryCloudEventsFormat to CloudEventsFormat
    DeliveryPlatformFormat to PlatformFormat
    MessageDelivery to MessageDeliveryPayload
    ResourceCreatedDelivery to ResourceCreatedDeliveryPayload
    ResourceDeletedDelivery to ResourceDeletedDeliveryPayload
    ResourceUpdatedDelivery to ResourceUpdatedDeliveryPayload
    SubscriptionDelivery to DeliveryPayload
  

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/2.5.1...3.0.0

# 2.5.1 (2022-02-23)

## What's Changed
* Fix type for OrderSearchRequest `query` field. Closes #138 


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/2.5.0...2.5.1

# 2.5.0 (2022-02-07)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/131
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/132


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/2.4.0...2.5.0

# 2.4.0 (2022-01-28)

## What's Changed
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/128
* fix mapping of pOBox field by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/130


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/2.3.0...2.4.0

# 2.3.0 (2022-01-25)

## What's Changed
* Checkout App Example by @MicheleRezk in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/107
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/125

Features

* Add support for product selection (beta)

Fixes

* Fix returnItemDraft type of field custom to CustomFieldsDraft
* Fix SetLineItemSupplyChannelAction for me cart endpoint
* Fix TransactionDraft type of field custom to CustomFieldDraft

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/2.2.0...2.3.0

# 2.2.0 (2022-01-14)

## What's Changed
* Adding a new section for SetupClient extension method by @MicheleRezk in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/118
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/119
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/124

* Support Head requests to check for existing products

## Breaking changes

* Fix return type for in-store cart query request
* Removed customerId query parameter for cart query request, use query cart by customer ID instead
* Fixed type for field `custom` in CartDiscountDraft
* Changed name of `ProjectChangeCartsConfiguration` to `ProjectChangeCartsConfigurationAction`
* Changed name of `ProjectChangeShoppingListsConfiguration` to `ProjectChangeShoppingListsConfigurationAction`
* Removed `inventory` requests for Import API

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/2.1.1...2.2.0

# 2.1.1 (2022-01-10)

## What's Changed
* unwrap MessageDelivery Payloads as IMessage by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/120
* remove unsupported endpoint inventories from Import API ProjectApiRoot

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/2.1.0...2.1.1

# 2.1.0 (2021-11-22)

## What's Changed
* Solving ImportOperation and ProcessingState Deserialization issues by @MicheleRezk in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/105
* Adding unit test for DeserializeResourceIdentifier by @MicheleRezk in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/108
* reformat by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/109
* Add project scoped apiroot by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/112
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/111

### Fix
- fix type for `value` of CartDiscount. Changed from CartDiscountDraft to CartDiscount

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/2.0.0...2.1.0

# 2.0.0 (2021-10-15)

## What's Changed

* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/99
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/101
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/102

Fixes:

- fix for product projection search with post method

Breaking Changes:
- to reflect differences between the read & write model the `DiscountedPrice` class has been split in `DiscountedPrice` and `DiscountPriceDraft`.

**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/1.5.0...2.0.0

# 1.5.0 (2021-10-14)

## What's Changed
* add helper methods/extensions for product attributes  by @jenschude in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/98
* Update generated SDKs by @github-actions in https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/pull/96


**Full Changelog**: https://github.com/commercetools/commercetools-dotnet-core-sdk-v2/compare/1.4.0...1.5.0

# 1.4.0 (2021-10-04)

Update generated SDKs

# 1.3.0 (2021-09-02)



# 1.2.1 (2021-08-30)

Adjust the User Agent to follow the same pattern like other Sdks

# 1.2.0 (2021-08-20)

- Adding History Api SDK 
- Adding Default Type Discriminator Attribute
- Update generated SDKs

# 1.1.0 (2021-08-02)

Update generated SDKs

# 1.0.1 (2021-07-13)

Stable release of the commercetools .NET Core SDK V2

# 1.0.0 (2021-07-13)



