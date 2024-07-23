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

