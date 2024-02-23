using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class ProductVariantImportDraft : IProductVariantImportDraft
    {
        public long? Id { get; set; }

        public string Sku { get; set; }

        public IList<IPriceDraft> Prices { get; set; }
        public IEnumerable<IPriceDraft> PricesEnumerable { set => Prices = value.ToList(); }


        public IList<IAttribute> Attributes { get; set; }
        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


        public IList<IImage> Images { get; set; }
        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

    }
}
