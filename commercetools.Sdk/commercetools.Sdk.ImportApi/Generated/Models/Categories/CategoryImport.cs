using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Categories
{
    public partial class CategoryImport : ICategoryImport
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString Description { get; set; }

        public ICategoryKeyReference Parent { get; set; }

        public string OrderHint { get; set; }

        public string ExternalId { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public List<IAsset> Assets { get; set; }

        public ICustom Custom { get; set; }
    }
}
