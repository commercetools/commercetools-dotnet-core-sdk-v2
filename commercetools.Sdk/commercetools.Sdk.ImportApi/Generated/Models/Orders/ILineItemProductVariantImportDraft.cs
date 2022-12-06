using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.LineItemProductVariantImportDraft))]
    public partial interface ILineItemProductVariantImportDraft
    {
        IProductVariantKeyReference ProductVariant { get; set; }

        string Sku { get; set; }

        IList<ILineItemPrice> Prices { get; set; }
        IEnumerable<ILineItemPrice> PricesEnumerable { set => Prices = value.ToList(); }


        IList<IAttribute> Attributes { get; set; }
        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


        IList<IImage> Images { get; set; }
        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


    }
}
