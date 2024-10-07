using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductTailoringCreatedMessagePayload : IProductTailoringCreatedMessagePayload
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public IStoreKeyReference Store { get; set; }

        public string ProductKey { get; set; }

        public IProductReference Product { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public IList<IProductVariantTailoring> Variants { get; set; }

        public IEnumerable<IProductVariantTailoring> VariantsEnumerable { set => Variants = value.ToList(); }

        public bool Published { get; set; }
        public ProductTailoringCreatedMessagePayload()
        {
            this.Type = "ProductTailoringCreated";
        }
    }
}
