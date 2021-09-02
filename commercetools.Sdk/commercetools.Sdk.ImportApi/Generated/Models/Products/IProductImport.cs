using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Products
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Products.ProductImport))]
    public partial interface IProductImport : IImportResource
    {
        ILocalizedString Name { get; set; }

        IProductTypeKeyReference ProductType { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString Description { get; set; }

        List<ICategoryKeyReference> Categories { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        ITaxCategoryKeyReference TaxCategory { get; set; }

        ISearchKeywords SearchKeywords { get; set; }

        IStateKeyReference State { get; set; }

        bool? Publish { get; set; }
    }
}
