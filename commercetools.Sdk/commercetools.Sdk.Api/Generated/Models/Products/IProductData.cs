using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductData))]
    public partial interface IProductData
    {
        ILocalizedString Name { get; set; }

        IList<ICategoryReference> Categories { get; set; }
        IEnumerable<ICategoryReference> CategoriesEnumerable { set => Categories = value.ToList(); }


        ICategoryOrderHints CategoryOrderHints { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        IProductVariant MasterVariant { get; set; }

        IList<IProductVariant> Variants { get; set; }
        IEnumerable<IProductVariant> VariantsEnumerable { set => Variants = value.ToList(); }


        ISearchKeywords SearchKeywords { get; set; }

    }
}
