using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class LineItem : ILineItem
    {
        public string Id { get; set;}
        
        public string ProductId { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString ProductSlug { get; set;}
        
        public IProductTypeReference ProductType { get; set;}
        
        public IProductVariant Variant { get; set;}
        
        public IPrice Price { get; set;}
        
        public ITaxedItemPrice TaxedPrice { get; set;}
        
        public ITypedMoney TotalPrice { get; set;}
        
        public long Quantity { get; set;}
        
        public DateTime AddedAt { get; set;}
        
        public List<IItemState> State { get; set;}
        
        public ITaxRate TaxRate { get; set;}
        
        public IChannelReference SupplyChannel { get; set;}
        
        public IChannelReference DistributionChannel { get; set;}
        
        public List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public ILineItemPriceMode PriceMode { get; set;}
        
        public ILineItemMode LineItemMode { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public IItemShippingDetails ShippingDetails { get; set;}
    }
}
