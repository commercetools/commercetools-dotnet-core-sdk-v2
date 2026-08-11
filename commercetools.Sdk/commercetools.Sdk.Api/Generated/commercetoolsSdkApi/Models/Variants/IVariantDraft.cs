using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantDraft))]
    public partial interface IVariantDraft
    {
        string Key { get; set; }

        string Sku { get; set; }

        IProductResourceIdentifier Product { get; set; }

        bool? Publish { get; set; }

        IList<IImage> Images { get; set; }

        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        IList<IAttribute> Attributes { get; set; }

        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        IList<IAssetDraft> Assets { get; set; }

        IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }

    }
}
