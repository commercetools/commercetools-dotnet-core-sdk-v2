using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.LineItemProductVariantImportDraft))]
    public partial interface ILineItemProductVariantImportDraft
    {
        IProductVariantKeyReference ProductVariant { get; set; }

        string Sku { get; set; }

        List<ILineItemPrice> Prices { get; set; }

        List<IAttribute> Attributes { get; set; }

        List<IImage> Images { get; set; }
    }
}
