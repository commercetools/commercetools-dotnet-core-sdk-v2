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

