using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class LineItemProductVariantImportDraft : ILineItemProductVariantImportDraft
    {
        public IProductVariantKeyReference ProductVariant { get; set;}
        
        public string Sku { get; set;}
        
        public List<ILineItemPrice> Prices { get; set;}
        
        public List<IAttribute> Attributes { get; set;}
        
        public List<IImage> Images { get; set;}
    }
}
