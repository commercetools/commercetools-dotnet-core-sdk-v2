using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Inventorys;
using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.ProductDiscounts;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.States;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.TaxCategorys;
using commercetools.Api.Models.Types;
using commercetools.Api.Models.Zones;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    [JsonConverter(typeof(JsonSubtypes), "typeId")]
    [JsonSubtypes.KnownSubType(typeof(CustomerGroupResourceIdentifier), "customer-group")]
    [JsonSubtypes.KnownSubType(typeof(CustomerResourceIdentifier), "customer")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeResourceIdentifier), "discount-code")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntryResourceIdentifier), "inventory-entry")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditResourceIdentifier), "order-edit")]
    [JsonSubtypes.KnownSubType(typeof(OrderResourceIdentifier), "order")]
    [JsonSubtypes.KnownSubType(typeof(PaymentResourceIdentifier), "payment")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountResourceIdentifier), "product-discount")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeResourceIdentifier), "product-type")]
    [JsonSubtypes.KnownSubType(typeof(ProductResourceIdentifier), "product")]
    [JsonSubtypes.KnownSubType(typeof(ReviewResourceIdentifier), "review")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodResourceIdentifier), "shipping-method")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListResourceIdentifier), "shopping-list")]
    [JsonSubtypes.KnownSubType(typeof(StateResourceIdentifier), "state")]
    [JsonSubtypes.KnownSubType(typeof(StoreResourceIdentifier), "store")]
    [JsonSubtypes.KnownSubType(typeof(TaxCategoryResourceIdentifier), "tax-category")]
    [JsonSubtypes.KnownSubType(typeof(TypeResourceIdentifier), "type")]
    [JsonSubtypes.KnownSubType(typeof(ZoneResourceIdentifier), "zone")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountResourceIdentifier), "cart-discount")]
    [JsonSubtypes.KnownSubType(typeof(CategoryResourceIdentifier), "category")]
    [JsonSubtypes.KnownSubType(typeof(CartResourceIdentifier), "cart")]
    [JsonSubtypes.KnownSubType(typeof(ChannelResourceIdentifier), "channel")]
    public abstract class ResourceIdentifier 
    {
        public ReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public string Key { get; set;}
    }
}
