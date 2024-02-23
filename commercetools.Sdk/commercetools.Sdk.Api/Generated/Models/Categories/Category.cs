using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class Category : ICategory
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<ICategoryReference> Ancestors { get; set; }
        public IEnumerable<ICategoryReference> AncestorsEnumerable { set => Ancestors = value.ToList(); }


        public ICategoryReference Parent { get; set; }

        public string OrderHint { get; set; }

        public string ExternalId { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public ICustomFields Custom { get; set; }

        public IList<IAsset> Assets { get; set; }
        public IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }


        public string Key { get; set; }
    }
}
