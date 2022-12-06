using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
using System.Linq;
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

        IList<ICategoryResourceIdentifier> Categories { get; set; }
        IEnumerable<ICategoryResourceIdentifier> CategoriesEnumerable { set => Categories = value.ToList(); }


        ICategoryOrderHints CategoryOrderHints { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        IProductVariantDraft MasterVariant { get; set; }

        IList<IProductVariantDraft> Variants { get; set; }
        IEnumerable<IProductVariantDraft> VariantsEnumerable { set => Variants = value.ToList(); }


        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        ISearchKeywords SearchKeywords { get; set; }

        IStateResourceIdentifier State { get; set; }

        bool? Publish { get; set; }

        IProductPriceModeEnum PriceMode { get; set; }

    }
}
