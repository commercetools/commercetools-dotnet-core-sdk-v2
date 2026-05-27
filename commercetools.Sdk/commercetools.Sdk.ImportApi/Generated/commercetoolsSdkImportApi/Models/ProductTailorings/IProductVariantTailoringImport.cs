using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.ProductTailorings.ProductVariantTailoringImport))]
    public partial interface IProductVariantTailoringImport
    {
        string Sku { get; set; }

        IList<IImage> Images { get; set; }

        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        IList<IAsset> Assets { get; set; }

        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

        IList<IAttribute> Attributes { get; set; }

        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

    }
}
