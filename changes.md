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

