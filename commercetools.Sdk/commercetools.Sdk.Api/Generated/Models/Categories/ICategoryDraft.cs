using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryDraft))]
    public partial interface ICategoryDraft
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString Description { get; set; }

        ICategoryResourceIdentifier Parent { get; set; }

        string OrderHint { get; set; }

        string ExternalId { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IList<IAssetDraft> Assets { get; set; }
        IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }


        string Key { get; set; }

    }
}
