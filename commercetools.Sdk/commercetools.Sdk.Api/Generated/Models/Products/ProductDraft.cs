using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductDraft : IProductDraft
    {
        public IProductTypeResourceIdentifier ProductType { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public string Key { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<ICategoryResourceIdentifier> Categories { get; set; }
        public IEnumerable<ICategoryResourceIdentifier> CategoriesEnumerable { set => Categories = value.ToList(); }


        public ICategoryOrderHints CategoryOrderHints { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public IProductVariantDraft MasterVariant { get; set; }

        public IList<IProductVariantDraft> Variants { get; set; }
        public IEnumerable<IProductVariantDraft> VariantsEnumerable { set => Variants = value.ToList(); }


        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public ISearchKeywords SearchKeywords { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Publish { get; set; }

        public IProductPriceModeEnum PriceMode { get; set; }
    }
}
