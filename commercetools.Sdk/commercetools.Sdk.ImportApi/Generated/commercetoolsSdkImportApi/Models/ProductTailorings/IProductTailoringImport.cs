using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.ProductTailorings.ProductTailoringImport))]
    public partial interface IProductTailoringImport : IImportResource
    {
        new string Key { get; set; }

        IStoreKeyReference Store { get; set; }

        IProductKeyReference Product { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        ILocalizedString Slug { get; set; }

        bool? Publish { get; set; }

        IList<IProductVariantTailoringImport> Variants { get; set; }

        IEnumerable<IProductVariantTailoringImport> VariantsEnumerable { set => Variants = value.ToList(); }

        IList<IAttribute> Attributes { get; set; }

        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

    }
}
