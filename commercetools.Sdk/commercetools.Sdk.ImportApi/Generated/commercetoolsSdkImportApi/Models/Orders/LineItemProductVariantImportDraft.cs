using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class LineItemProductVariantImportDraft : ILineItemProductVariantImportDraft
    {
        public IProductVariantKeyReference ProductVariant { get; set; }

        public string Sku { get; set; }

        public IList<ILineItemPrice> Prices { get; set; }
        public IEnumerable<ILineItemPrice> PricesEnumerable { set => Prices = value.ToList(); }


        public IList<IAttribute> Attributes { get; set; }
        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


        public IList<IImage> Images { get; set; }
        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

    }
}
