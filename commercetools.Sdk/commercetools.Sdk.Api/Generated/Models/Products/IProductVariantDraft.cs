using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductVariantDraft))]
    public partial interface IProductVariantDraft
    {
        string Sku { get; set; }

        string Key { get; set; }

        List<IPriceDraft> Prices { get; set; }

        List<IAttribute> Attributes { get; set; }

        List<IImage> Images { get; set; }

        List<IAssetDraft> Assets { get; set; }
    }
}
