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

