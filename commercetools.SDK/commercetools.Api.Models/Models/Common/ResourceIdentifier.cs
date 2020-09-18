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
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [Discriminator(nameof(TypeId))]
    public abstract class ResourceIdentifier 
    {
        public string TypeId { get; set;}
        
        public ReferenceTypeId TypeIdAsEnum => this.TypeId.GetEnum<ReferenceTypeId>();
        
        public string Id { get; set;}
        
        public string Key { get; set;}
    }
}
