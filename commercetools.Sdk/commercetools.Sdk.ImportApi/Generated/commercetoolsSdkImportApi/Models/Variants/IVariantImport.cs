using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Variants.VariantImport))]
    public partial interface IVariantImport : IImportResource
    {
        new string Key { get; set; }

        string Sku { get; set; }

        IProductKeyReference Product { get; set; }

        bool? Publish { get; set; }

        IList<IImage> Images { get; set; }

        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        IList<IAttribute> Attributes { get; set; }

        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        IList<IAsset> Assets { get; set; }

        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

    }
}
