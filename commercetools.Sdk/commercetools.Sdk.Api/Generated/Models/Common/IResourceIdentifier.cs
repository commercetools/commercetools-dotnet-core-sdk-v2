using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupResourceIdentifier))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Api.Models.Customers.CustomerResourceIdentifier))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeResourceIdentifier))]
    [SubTypeDiscriminator("inventory-entry", typeof(commercetools.Api.Models.Inventories.InventoryEntryResourceIdentifier))]
    [SubTypeDiscriminator("order-edit", typeof(commercetools.Api.Models.OrderEdits.OrderEditResourceIdentifier))]
    [SubTypeDiscriminator("order", typeof(commercetools.Api.Models.Orders.OrderResourceIdentifier))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Api.Models.Payments.PaymentResourceIdentifier))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountResourceIdentifier))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Api.Models.ProductTypes.ProductTypeResourceIdentifier))]
    [SubTypeDiscriminator("product", typeof(commercetools.Api.Models.Products.ProductResourceIdentifier))]
    [SubTypeDiscriminator("review", typeof(commercetools.Api.Models.Reviews.ReviewResourceIdentifier))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodResourceIdentifier))]
    [SubTypeDiscriminator("shopping-list", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListResourceIdentifier))]
    [SubTypeDiscriminator("state", typeof(commercetools.Api.Models.States.StateResourceIdentifier))]
    [SubTypeDiscriminator("store", typeof(commercetools.Api.Models.Stores.StoreResourceIdentifier))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Api.Models.TaxCategories.TaxCategoryResourceIdentifier))]
    [SubTypeDiscriminator("type", typeof(commercetools.Api.Models.Types.TypeResourceIdentifier))]
    [SubTypeDiscriminator("zone", typeof(commercetools.Api.Models.Zones.ZoneResourceIdentifier))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Api.Models.Carts.CartResourceIdentifier))]
    [SubTypeDiscriminator("category", typeof(commercetools.Api.Models.Categories.CategoryResourceIdentifier))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Api.Models.Channels.ChannelResourceIdentifier))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountResourceIdentifier))]
    public partial interface IResourceIdentifier 
    {
        string TypeId { get; set;}
        
        ReferenceTypeId TypeIdAsEnum { get; }
        
        string Id { get; set;}
        
        string Key { get; set;}
    }
}
