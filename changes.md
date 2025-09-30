**Api changes**

<details>
<summary>Added Type(s)</summary>

- added type `PaymentTransactionInterfaceIdSetMessage`
- added type `PaymentTransactionInterfaceIdSetMessagePayload`
- added type `PaymentSetTransactionInterfaceIdAction`
- added type `DiscountCombinationMode`
- added type `DiscountsConfiguration`
- added type `ProjectSetDiscountsConfigurationAction`
- added type `SearchFuzzyExpression`
- added type `SearchFuzzyValue`
</details>


<details>
<summary>Added QueryParameter(s)</summary>

- added query parameter `filter[attributes]` to method `get /{projectKey}/product-projections`
- added query parameter `filter[attributes]` to method `get /{projectKey}/product-projections/key={key}`
- added query parameter `filter[attributes]` to method `get /{projectKey}/product-projections/{ID}`
- added query parameter `filter[attributes]` to method `get /{projectKey}/in-store/key={storeKey}/product-projections/key={key}`
- added query parameter `filter[attributes]` to method `get /{projectKey}/in-store/key={storeKey}/product-projections/{ID}`
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `startsAt` of type `RecurringOrderDraft` to be optional
</details>


<details>
<summary>Removed Property(s)</summary>

- :warning: removed property `skipConfiguration` from type `RecurringOrderSetOrderSkipConfigurationAction`
</details>


<details>
<summary>Added Property(s)</summary>

- added property `applicationMode` to type `CartDiscountValueRelative`
- added property `applicationMode` to type `CartDiscountValueRelativeDraft`
- added property `interfaceId` to type `MyTransactionDraft`
- added property `interfaceId` to type `Transaction`
- added property `interfaceId` to type `TransactionDraft`
- added property `discounts` to type `Project`
- added property `skipConfigurationInputDraft` to type `RecurringOrderSetOrderSkipConfigurationAction`
</details>

