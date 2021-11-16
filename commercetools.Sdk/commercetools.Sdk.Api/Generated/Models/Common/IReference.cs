using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Common.Reference))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Api.Models.Carts.CartReference))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountReference))]
    [SubTypeDiscriminator("category", typeof(commercetools.Api.Models.Categories.CategoryReference))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Api.Models.Channels.ChannelReference))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Api.Models.Customers.CustomerReference))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupReference))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeReference))]
    [SubTypeDiscriminator("inventory-entry", typeof(commercetools.Api.Models.Inventories.InventoryEntryReference))]
    [SubTypeDiscriminator("key-value-document", typeof(commercetools.Api.Models.CustomObjects.CustomObjectReference))]
    [SubTypeDiscriminator("order", typeof(commercetools.Api.Models.Orders.OrderReference))]
    [SubTypeDiscriminator("order-edit", typeof(commercetools.Api.Models.OrderEdits.OrderEditReference))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Api.Models.Payments.PaymentReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.Api.Models.Products.ProductReference))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Api.Models.ProductTypes.ProductTypeReference))]
    [SubTypeDiscriminator("review", typeof(commercetools.Api.Models.Reviews.ReviewReference))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodReference))]
    [SubTypeDiscriminator("shopping-list", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListReference))]
    [SubTypeDiscriminator("state", typeof(commercetools.Api.Models.States.StateReference))]
    [SubTypeDiscriminator("store", typeof(commercetools.Api.Models.Stores.StoreReference))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Api.Models.TaxCategories.TaxCategoryReference))]
    [SubTypeDiscriminator("type", typeof(commercetools.Api.Models.Types.TypeReference))]
    [SubTypeDiscriminator("zone", typeof(commercetools.Api.Models.Zones.ZoneReference))]
    public partial interface IReference 
    {
        IReferenceTypeId TypeId { get; set;}
        
        string Id { get; set;}
    }
}
