using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productdrafts
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productdrafts.ProductDraftImport))]
    public partial interface IProductDraftImport : IImportResource
    {
        new string Key { get; set; }

        IProductTypeKeyReference ProductType { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString Description { get; set; }

        IList<ICategoryKeyReference> Categories { get; set; }

        IEnumerable<ICategoryKeyReference> CategoriesEnumerable { set => Categories = value.ToList(); }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        IProductVariantDraftImport MasterVariant { get; set; }

        IList<IProductVariantDraftImport> Variants { get; set; }

        IEnumerable<IProductVariantDraftImport> VariantsEnumerable { set => Variants = value.ToList(); }

        ITaxCategoryKeyReference TaxCategory { get; set; }

        ISearchKeywords SearchKeywords { get; set; }

        IStateKeyReference State { get; set; }

        bool? Publish { get; set; }

        IProductPriceModeEnum PriceMode { get; set; }

    }
}
