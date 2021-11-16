using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.LineItemProductVariantImportDraft))]
    public partial interface ILineItemProductVariantImportDraft 
    {
        IProductVariantKeyReference ProductVariant { get; set;}
        
        string Sku { get; set;}
        
        List<ILineItemPrice> Prices { get; set;}
        
        List<IAttribute> Attributes { get; set;}
        
        List<IImage> Images { get; set;}
    }
}
