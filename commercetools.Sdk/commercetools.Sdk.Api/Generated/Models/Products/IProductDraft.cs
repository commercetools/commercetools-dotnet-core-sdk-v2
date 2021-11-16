using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.States;
using commercetools.Api.Models.TaxCategories;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductDraft))]
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
    }
}
