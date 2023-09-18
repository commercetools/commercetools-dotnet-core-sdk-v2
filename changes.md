**Api changes**

<details>
<summary>Removed Resource(s)</summary>

- :warning: removed resource `/{projectKey}/me/payments/key={key}`
</details>


<details>
<summary>Removed Method(s)</summary>

- :warning: removed method `apiRoot.withProjectKey().me().payments().withKey().get()`
- :warning: removed method `apiRoot.withProjectKey().me().payments().withKey().post()`
- :warning: removed method `apiRoot.withProjectKey().me().payments().withKey().delete()`
</details>


<details>
<summary>Added Type(s)</summary>

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

