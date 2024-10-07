using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddVariantAction))]
    public partial interface IProductTailoringAddVariantAction : IProductTailoringUpdateAction
    {
        long? Id { get; set; }

        string Sku { get; set; }

        IList<IImage> Images { get; set; }

        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        IList<IAssetDraft> Assets { get; set; }

        IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }

        IList<IProductTailoringAttribute> Attributes { get; set; }

        IEnumerable<IProductTailoringAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        bool? Staged { get; set; }

    }
}
