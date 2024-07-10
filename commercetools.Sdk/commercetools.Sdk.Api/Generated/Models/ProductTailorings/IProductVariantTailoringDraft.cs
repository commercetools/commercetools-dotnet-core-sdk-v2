using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductVariantTailoringDraft))]
    public partial interface IProductVariantTailoringDraft
    {
        long? Id { get; set; }

        string Sku { get; set; }

        IList<IImage> Images { get; set; }
        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


        IList<IAsset> Assets { get; set; }
        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }


    }
}
