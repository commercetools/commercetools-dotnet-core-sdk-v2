using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productdrafts
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productdrafts.ProductDraftImport))]
    public partial interface IProductDraftImport : IImportResource
    {
        IProductTypeKeyReference ProductType { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString Description { get; set; }

        List<ICategoryKeyReference> Categories { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        IProductVariantDraftImport MasterVariant { get; set; }

        List<IProductVariantDraftImport> Variants { get; set; }

        ITaxCategoryKeyReference TaxCategory { get; set; }

        ISearchKeywords SearchKeywords { get; set; }

        IStateKeyReference State { get; set; }

        bool? Publish { get; set; }

        IProductPriceModeEnum PriceMode { get; set; }

    }
}
