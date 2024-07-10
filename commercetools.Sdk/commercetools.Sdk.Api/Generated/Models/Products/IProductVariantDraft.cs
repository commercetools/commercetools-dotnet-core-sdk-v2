using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductVariantDraft))]
    public partial interface IProductVariantDraft
    {
        string Sku { get; set; }

        string Key { get; set; }

        IList<IPriceDraft> Prices { get; set; }
        IEnumerable<IPriceDraft> PricesEnumerable { set => Prices = value.ToList(); }


        IList<IAttribute> Attributes { get; set; }
        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


        IList<IImage> Images { get; set; }
        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


        IList<IAssetDraft> Assets { get; set; }
        IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }


    }
}
