using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ProductVariantImportDraft))]
    public partial interface IProductVariantImportDraft
    {
        long? Id { get; set; }

        string Sku { get; set; }

        IList<IPriceDraft> Prices { get; set; }
        IEnumerable<IPriceDraft> PricesEnumerable { set => Prices = value.ToList(); }


        IList<IAttribute> Attributes { get; set; }
        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


        IList<IImage> Images { get; set; }
        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


    }
}
