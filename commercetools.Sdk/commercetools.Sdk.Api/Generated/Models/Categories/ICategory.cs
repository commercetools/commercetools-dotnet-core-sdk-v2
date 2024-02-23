using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.Category))]
    public partial interface ICategory : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString Description { get; set; }

        IList<ICategoryReference> Ancestors { get; set; }
        IEnumerable<ICategoryReference> AncestorsEnumerable { set => Ancestors = value.ToList(); }


        ICategoryReference Parent { get; set; }

        string OrderHint { get; set; }

        string ExternalId { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        ICustomFields Custom { get; set; }

        IList<IAsset> Assets { get; set; }
        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }


        string Key { get; set; }

    }
}
