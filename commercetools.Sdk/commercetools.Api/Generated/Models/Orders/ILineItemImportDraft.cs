using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.TaxCategories;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface ILineItemImportDraft 
    {
        string ProductId { get; set;}
        
        ILocalizedString Name { get; set;}
        
        IProductVariantImportDraft Variant { get; set;}
        
        IPriceDraft Price { get; set;}
        
        double Quantity { get; set;}
        
        List<IItemState> State { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
        
        ITaxRate TaxRate { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
