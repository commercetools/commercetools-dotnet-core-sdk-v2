using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringInStoreDraft))]
    public partial interface IProductTailoringInStoreDraft
    {
        string Key { get; set; }

        IProductResourceIdentifier Product { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        ILocalizedString Slug { get; set; }

        bool? Publish { get; set; }

        IList<IProductVariantTailoringDraft> Variants { get; set; }

        IEnumerable<IProductVariantTailoringDraft> VariantsEnumerable { set => Variants = value.ToList(); }

        IList<IProductTailoringAttribute> Attributes { get; set; }

        IEnumerable<IProductTailoringAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

    }
}
