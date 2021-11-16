using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.LineItem))]
    public partial interface ILineItem 
    {
        string Id { get; set;}
        
        string ProductId { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString ProductSlug { get; set;}
        
        IProductTypeReference ProductType { get; set;}
        
        IProductVariant Variant { get; set;}
        
        IPrice Price { get; set;}
        
        ITaxedItemPrice TaxedPrice { get; set;}
        
        ITypedMoney TotalPrice { get; set;}
        
        long Quantity { get; set;}
        
        DateTime? AddedAt { get; set;}
        
        List<IItemState> State { get; set;}
        
        ITaxRate TaxRate { get; set;}
        
        IChannelReference SupplyChannel { get; set;}
        
        IChannelReference DistributionChannel { get; set;}
        
        List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        ILineItemPriceMode PriceMode { get; set;}
        
        ILineItemMode LineItemMode { get; set;}
        
        ICustomFields Custom { get; set;}
        
        IItemShippingDetails ShippingDetails { get; set;}
        
        DateTime? LastModifiedAt { get; set;}
    }
}
