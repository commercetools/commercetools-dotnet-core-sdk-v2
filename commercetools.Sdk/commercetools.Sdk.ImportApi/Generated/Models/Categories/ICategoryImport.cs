using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Categories.CategoryImport))]
    public partial interface ICategoryImport : IImportResource
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString Description { get; set; }

        ICategoryKeyReference Parent { get; set; }

        string OrderHint { get; set; }

        string ExternalId { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        IList<IAsset> Assets { get; set; }
        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }


        ICustom Custom { get; set; }

    }
}
