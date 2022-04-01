using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ProductVariantImportDraft))]
    public partial interface IProductVariantImportDraft
    {
        long? Id { get; set; }

        string Sku { get; set; }

        List<IPriceDraft> Prices { get; set; }

        List<IAttribute> Attributes { get; set; }

        List<IImage> Images { get; set; }
    }
}
