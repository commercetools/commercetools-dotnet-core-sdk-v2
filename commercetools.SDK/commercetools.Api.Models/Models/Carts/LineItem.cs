using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.TaxCategorys;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class LineItem 
    {
        public string Id { get; set;}
        
        public string ProductId { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString ProductSlug { get; set;}
        
        public ProductTypeReference ProductType { get; set;}
        
        public ProductVariant Variant { get; set;}
        
        public Price Price { get; set;}
        
        public TaxedItemPrice TaxedPrice { get; set;}
        
        public TypedMoney TotalPrice { get; set;}
        
        public long Quantity { get; set;}
        
        public DateTime AddedAt { get; set;}
        
        public List<ItemState> State { get; set;}
        
        public TaxRate TaxRate { get; set;}
        
        public ChannelReference SupplyChannel { get; set;}
        
        public ChannelReference DistributionChannel { get; set;}
        
        public List<DiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public string PriceMode { get; set;}
        
        [JsonIgnore]
        public LineItemPriceMode PriceModeAsEnum => this.PriceMode.GetEnum<LineItemPriceMode>();
        
        public string LineItemMode { get; set;}
        
        [JsonIgnore]
        public LineItemMode LineItemModeAsEnum => this.LineItemMode.GetEnum<LineItemMode>();
        
        public CustomFields Custom { get; set;}
        
        public ItemShippingDetails ShippingDetails { get; set;}
    }
}
