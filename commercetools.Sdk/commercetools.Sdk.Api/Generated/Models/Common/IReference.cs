using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Common.Reference))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Sdk.Api.Models.Carts.CartReference))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountReference))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.Api.Models.Categories.CategoryReference))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Sdk.Api.Models.Channels.ChannelReference))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Sdk.Api.Models.Customers.CustomerReference))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupReference))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeReference))]
    [SubTypeDiscriminator("inventory-entry", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryReference))]
    [SubTypeDiscriminator("key-value-document", typeof(commercetools.Sdk.Api.Models.CustomObjects.CustomObjectReference))]
    [SubTypeDiscriminator("order", typeof(commercetools.Sdk.Api.Models.Orders.OrderReference))]
    [SubTypeDiscriminator("order-edit", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditReference))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Sdk.Api.Models.Payments.PaymentReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.Api.Models.Products.ProductReference))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountReference))]
    [SubTypeDiscriminator("product-selection", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeReference))]
    [SubTypeDiscriminator("quote", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteReference))]
    [SubTypeDiscriminator("quote-request", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestReference))]
    [SubTypeDiscriminator("review", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewReference))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodReference))]
    [SubTypeDiscriminator("shopping-list", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListReference))]
    [SubTypeDiscriminator("staged-quote", typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteReference))]
    [SubTypeDiscriminator("standalone-price", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceReference))]
    [SubTypeDiscriminator("state", typeof(commercetools.Sdk.Api.Models.States.StateReference))]
    [SubTypeDiscriminator("store", typeof(commercetools.Sdk.Api.Models.Stores.StoreReference))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReference))]
    [SubTypeDiscriminator("type", typeof(commercetools.Sdk.Api.Models.Types.TypeReference))]
    [SubTypeDiscriminator("zone", typeof(commercetools.Sdk.Api.Models.Zones.ZoneReference))]
    public partial interface IReference
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }
    }
}
