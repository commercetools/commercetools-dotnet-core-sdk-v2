using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Products.ProductImport))]
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

        IProductPriceModeEnum PriceMode { get; set; }

    }
}
