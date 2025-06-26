using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringData))]
    public partial interface IProductTailoringData
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        ILocalizedString Slug { get; set; }

        IList<IProductVariantTailoring> Variants { get; set; }

        IEnumerable<IProductVariantTailoring> VariantsEnumerable { set => Variants = value.ToList(); }

        IList<IProductTailoringAttribute> Attributes { get; set; }

        IEnumerable<IProductTailoringAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

    }
}
