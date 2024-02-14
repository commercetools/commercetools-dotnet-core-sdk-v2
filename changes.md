**Api changes**

<details>
<summary>Added Type(s)</summary>

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


<details>
<summary>Added Property(s)</summary>

- added property `perMethodExternalTaxRate` to type `CartAddLineItemAction`
- added property `key` to type `DiscountCode`
- added property `key` to type `DiscountCodeDraft`
- added property `shippingMode` to type `MyCartDraft`
</details>

