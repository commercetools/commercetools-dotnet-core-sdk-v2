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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetTagsAction))]
    public partial interface IProductSetAssetTagsAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }

        string AssetId { get; set; }

        string AssetKey { get; set; }

        IList<string> Tags { get; set; }
        IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }


    }
}
