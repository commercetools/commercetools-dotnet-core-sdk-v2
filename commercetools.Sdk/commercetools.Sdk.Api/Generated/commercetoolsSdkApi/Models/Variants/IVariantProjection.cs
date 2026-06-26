using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantProjection))]
    public partial interface IVariantProjection
    {
        string Id { get; set; }

        long Version { get; set; }

        DateTime CreatedAt { get; set; }

        bool Staged { get; set; }

        int VariantId { get; set; }

        IProductReference Product { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString Description { get; set; }

        string Key { get; set; }

        string Sku { get; set; }

        IList<IImage> Images { get; set; }

        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        IList<IAsset> Assets { get; set; }

        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

        IList<IAttribute> Attributes { get; set; }

        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        IPrice Price { get; set; }

        bool Default { get; set; }

    }
}
