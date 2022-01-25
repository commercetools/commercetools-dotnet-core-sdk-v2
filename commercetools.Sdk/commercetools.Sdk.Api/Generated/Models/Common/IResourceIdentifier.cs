using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Common.ResourceIdentifier))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Api.Models.Carts.CartResourceIdentifier))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountResourceIdentifier))]
    [SubTypeDiscriminator("category", typeof(commercetools.Api.Models.Categories.CategoryResourceIdentifier))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Api.Models.Channels.ChannelResourceIdentifier))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Api.Models.Customers.CustomerResourceIdentifier))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupResourceIdentifier))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeResourceIdentifier))]
    [SubTypeDiscriminator("inventory-entry", typeof(commercetools.Api.Models.Inventories.InventoryEntryResourceIdentifier))]
    [SubTypeDiscriminator("order", typeof(commercetools.Api.Models.Orders.OrderResourceIdentifier))]
    [SubTypeDiscriminator("order-edit", typeof(commercetools.Api.Models.OrderEdits.OrderEditResourceIdentifier))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Api.Models.Payments.PaymentResourceIdentifier))]
    [SubTypeDiscriminator("product", typeof(commercetools.Api.Models.Products.ProductResourceIdentifier))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountResourceIdentifier))]
    [SubTypeDiscriminator("product-selection", typeof(commercetools.Api.Models.ProductSelections.ProductSelectionResourceIdentifier))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Api.Models.ProductTypes.ProductTypeResourceIdentifier))]
    [SubTypeDiscriminator("review", typeof(commercetools.Api.Models.Reviews.ReviewResourceIdentifier))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodResourceIdentifier))]
    [SubTypeDiscriminator("shopping-list", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListResourceIdentifier))]
    [SubTypeDiscriminator("state", typeof(commercetools.Api.Models.States.StateResourceIdentifier))]
    [SubTypeDiscriminator("store", typeof(commercetools.Api.Models.Stores.StoreResourceIdentifier))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Api.Models.TaxCategories.TaxCategoryResourceIdentifier))]
    [SubTypeDiscriminator("type", typeof(commercetools.Api.Models.Types.TypeResourceIdentifier))]
    [SubTypeDiscriminator("zone", typeof(commercetools.Api.Models.Zones.ZoneResourceIdentifier))]
    public partial interface IResourceIdentifier
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        string Key { get; set; }
    }
}
