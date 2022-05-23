using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductDraft))]
    public partial interface IProductDraft
    {
        IProductTypeResourceIdentifier ProductType { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        string Key { get; set; }

        ILocalizedString Description { get; set; }

        List<ICategoryResourceIdentifier> Categories { get; set; }

        ICategoryOrderHints CategoryOrderHints { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        IProductVariantDraft MasterVariant { get; set; }

        List<IProductVariantDraft> Variants { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        ISearchKeywords SearchKeywords { get; set; }

        IStateResourceIdentifier State { get; set; }

        bool? Publish { get; set; }

        IProductPriceModeEnum PriceMode { get; set; }
    }
}
