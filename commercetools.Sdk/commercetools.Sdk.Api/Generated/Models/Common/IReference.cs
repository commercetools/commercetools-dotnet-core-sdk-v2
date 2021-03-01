using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [SubTypeDiscriminator("key-value-document", typeof(commercetools.Api.Models.CustomObjects.CustomObjectReference))]
    [SubTypeDiscriminator("customer-group", typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupReference))]
    [SubTypeDiscriminator("customer", typeof(commercetools.Api.Models.Customers.CustomerReference))]
    [SubTypeDiscriminator("discount-code", typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeReference))]
    [SubTypeDiscriminator("inventory-entry", typeof(commercetools.Api.Models.Inventories.InventoryEntryReference))]
    [SubTypeDiscriminator("order-edit", typeof(commercetools.Api.Models.OrderEdits.OrderEditReference))]
    [SubTypeDiscriminator("order", typeof(commercetools.Api.Models.Orders.OrderReference))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Api.Models.Payments.PaymentReference))]
    [SubTypeDiscriminator("product-discount", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountReference))]
    [SubTypeDiscriminator("product-type", typeof(commercetools.Api.Models.ProductTypes.ProductTypeReference))]
    [SubTypeDiscriminator("product", typeof(commercetools.Api.Models.Products.ProductReference))]
    [SubTypeDiscriminator("review", typeof(commercetools.Api.Models.Reviews.ReviewReference))]
    [SubTypeDiscriminator("shipping-method", typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodReference))]
    [SubTypeDiscriminator("shopping-list", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListReference))]
    [SubTypeDiscriminator("state", typeof(commercetools.Api.Models.States.StateReference))]
    [SubTypeDiscriminator("store", typeof(commercetools.Api.Models.Stores.StoreReference))]
    [SubTypeDiscriminator("tax-category", typeof(commercetools.Api.Models.TaxCategories.TaxCategoryReference))]
    [SubTypeDiscriminator("type", typeof(commercetools.Api.Models.Types.TypeReference))]
    [SubTypeDiscriminator("zone", typeof(commercetools.Api.Models.Zones.ZoneReference))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Api.Models.Carts.CartReference))]
    [SubTypeDiscriminator("cart-discount", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountReference))]
    [SubTypeDiscriminator("category", typeof(commercetools.Api.Models.Categories.CategoryReference))]
    [SubTypeDiscriminator("channel", typeof(commercetools.Api.Models.Channels.ChannelReference))]
    public partial interface IReference 
    {
        IReferenceTypeId TypeId { get; set;}
        
        string Id { get; set;}
    }
}
