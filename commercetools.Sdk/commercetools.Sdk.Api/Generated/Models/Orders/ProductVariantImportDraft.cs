using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class ProductVariantImportDraft : IProductVariantImportDraft
    {
        public long? Id { get; set; }

        public string Sku { get; set; }

        public List<IPriceDraft> Prices { get; set; }

        public List<IAttribute> Attributes { get; set; }

        public List<IImage> Images { get; set; }
    }
}
