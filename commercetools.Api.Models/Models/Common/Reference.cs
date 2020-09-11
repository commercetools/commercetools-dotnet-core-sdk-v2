using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomObjects;
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
    [JsonSubtypes.KnownSubType(typeof(CustomObjectReference), "key-value-document")]
    [JsonSubtypes.KnownSubType(typeof(CustomerGroupReference), "customer-group")]
    [JsonSubtypes.KnownSubType(typeof(CustomerReference), "customer")]
    [JsonSubtypes.KnownSubType(typeof(DiscountCodeReference), "discount-code")]
    [JsonSubtypes.KnownSubType(typeof(InventoryEntryReference), "inventory-entry")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditReference), "order-edit")]
    [JsonSubtypes.KnownSubType(typeof(OrderReference), "order")]
    [JsonSubtypes.KnownSubType(typeof(PaymentReference), "payment")]
    [JsonSubtypes.KnownSubType(typeof(ProductDiscountReference), "product-discount")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeReference), "product-type")]
    [JsonSubtypes.KnownSubType(typeof(ProductReference), "product")]
    [JsonSubtypes.KnownSubType(typeof(ReviewReference), "review")]
    [JsonSubtypes.KnownSubType(typeof(ShippingMethodReference), "shipping-method")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListReference), "shopping-list")]
    [JsonSubtypes.KnownSubType(typeof(StateReference), "state")]
    [JsonSubtypes.KnownSubType(typeof(StoreReference), "store")]
    [JsonSubtypes.KnownSubType(typeof(TaxCategoryReference), "tax-category")]
    [JsonSubtypes.KnownSubType(typeof(TypeReference), "type")]
    [JsonSubtypes.KnownSubType(typeof(ZoneReference), "zone")]
    [JsonSubtypes.KnownSubType(typeof(CartReference), "cart")]
    [JsonSubtypes.KnownSubType(typeof(ChannelReference), "channel")]
    [JsonSubtypes.KnownSubType(typeof(CategoryReference), "category")]
    [JsonSubtypes.KnownSubType(typeof(CartDiscountReference), "cart-discount")]
    public abstract class Reference 
    {
        public ReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
    }
}
