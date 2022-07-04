using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Common.ResourceIdentifier))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Sdk.Api.Models.Carts.CartResourceIdentifier))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountResourceIdentifier))]
    [SubTypeDiscriminator("category", typeof(commercetools.Sdk.Api.Models.Categories.CategoryResourceIdentifier))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Sdk.Api.Models.Channels.ChannelResourceIdentifier))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Sdk.Api.Models.Customers.CustomerResourceIdentifier))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupResourceIdentifier))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeResourceIdentifier))]
    [SubTypeDiscriminator("inventory-entry", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryResourceIdentifier))]
    [SubTypeDiscriminator("order", typeof(commercetools.Sdk.Api.Models.Orders.OrderResourceIdentifier))]
    [SubTypeDiscriminator("order-edit", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditResourceIdentifier))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Sdk.Api.Models.Payments.PaymentResourceIdentifier))]
    [SubTypeDiscriminator("product", typeof(commercetools.Sdk.Api.Models.Products.ProductResourceIdentifier))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountResourceIdentifier))]
    [SubTypeDiscriminator("product-selection", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionResourceIdentifier))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeResourceIdentifier))]
    [SubTypeDiscriminator("quote", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteResourceIdentifier))]
    [SubTypeDiscriminator("quote-request", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestResourceIdentifier))]
    [SubTypeDiscriminator("review", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewResourceIdentifier))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodResourceIdentifier))]
    [SubTypeDiscriminator("shopping-list", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListResourceIdentifier))]
    [SubTypeDiscriminator("staged-quote", typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteResourceIdentifier))]
    [SubTypeDiscriminator("standalone-price", typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceResourceIdentifier))]
    [SubTypeDiscriminator("state", typeof(commercetools.Sdk.Api.Models.States.StateResourceIdentifier))]
    [SubTypeDiscriminator("store", typeof(commercetools.Sdk.Api.Models.Stores.StoreResourceIdentifier))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryResourceIdentifier))]
    [SubTypeDiscriminator("type", typeof(commercetools.Sdk.Api.Models.Types.TypeResourceIdentifier))]
    [SubTypeDiscriminator("zone", typeof(commercetools.Sdk.Api.Models.Zones.ZoneResourceIdentifier))]
    public partial interface IResourceIdentifier
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        string Key { get; set; }
    }
}
