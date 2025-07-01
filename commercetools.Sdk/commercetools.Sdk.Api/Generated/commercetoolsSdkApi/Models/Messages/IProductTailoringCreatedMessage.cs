using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringCreatedMessage))]
    public partial interface IProductTailoringCreatedMessage : IMessage
    {
        string Key { get; set; }

        IStoreKeyReference Store { get; set; }

        string ProductKey { get; set; }

        IProductReference Product { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        IList<IProductVariantTailoring> Variants { get; set; }

        IEnumerable<IProductVariantTailoring> VariantsEnumerable { set => Variants = value.ToList(); }

        IList<IProductTailoringAttribute> Attributes { get; set; }

        IEnumerable<IProductTailoringAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        bool Published { get; set; }

    }
}
