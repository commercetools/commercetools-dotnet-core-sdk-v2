using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryDraft : ICategoryDraft
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString Description { get; set; }

        public ICategoryResourceIdentifier Parent { get; set; }

        public string OrderHint { get; set; }

        public string ExternalId { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IList<IAssetDraft> Assets { get; set; }

        public IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }

        public string Key { get; set; }
    }
}
