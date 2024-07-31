using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.ProductVariantImport))]
    public partial interface IProductVariantImport : IImportResource
    {
        new string Key { get; set; }

        string Sku { get; set; }

        bool IsMasterVariant { get; set; }

        IList<IAttribute> Attributes { get; set; }

        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        IList<IImage> Images { get; set; }

        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        IList<IAsset> Assets { get; set; }

        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

        [ObsoleteAttribute("This property is obsolete", false)]
        bool? Publish { get; set; }

        bool? Staged { get; set; }

        IProductKeyReference Product { get; set; }

    }
}
