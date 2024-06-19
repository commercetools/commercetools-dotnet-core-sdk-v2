**Api changes**

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
<summary>Required Property(s)</summary>

- changed property `isOnStock` of type `ProductVariantAvailability` to be optional
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

