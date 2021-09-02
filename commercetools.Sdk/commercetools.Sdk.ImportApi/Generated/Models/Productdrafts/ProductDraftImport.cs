using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productdrafts;
using commercetools.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productdrafts
{
    public partial class ProductDraftImport : IProductDraftImport
    {
        public string Key { get; set; }

        public IProductTypeKeyReference ProductType { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString Description { get; set; }

        public List<ICategoryKeyReference> Categories { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public IProductVariantDraftImport MasterVariant { get; set; }

        public List<IProductVariantDraftImport> Variants { get; set; }

        public ITaxCategoryKeyReference TaxCategory { get; set; }

        public ISearchKeywords SearchKeywords { get; set; }

        public IStateKeyReference State { get; set; }

        public bool? Publish { get; set; }
    }
}
