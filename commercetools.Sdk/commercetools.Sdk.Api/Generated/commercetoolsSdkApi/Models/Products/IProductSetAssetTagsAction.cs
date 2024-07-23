using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
