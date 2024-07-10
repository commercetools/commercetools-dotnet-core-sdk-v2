using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringDraft))]
    public partial interface IProductTailoringDraft
    {
        string Key { get; set; }

        IStoreResourceIdentifier Store { get; set; }

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


    }
}
