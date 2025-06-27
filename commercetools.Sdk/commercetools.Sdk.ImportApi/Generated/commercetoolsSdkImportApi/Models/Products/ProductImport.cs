using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Products
{

    public partial class ProductImport : IProductImport
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public IProductTypeKeyReference ProductType { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<ICategoryKeyReference> Categories { get; set; }

        public IEnumerable<ICategoryKeyReference> CategoriesEnumerable { set => Categories = value.ToList(); }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public ITaxCategoryKeyReference TaxCategory { get; set; }

        public ISearchKeywords SearchKeywords { get; set; }

        public IStateKeyReference State { get; set; }

        public bool? Publish { get; set; }

        public IProductPriceModeEnum PriceMode { get; set; }
    }
}
