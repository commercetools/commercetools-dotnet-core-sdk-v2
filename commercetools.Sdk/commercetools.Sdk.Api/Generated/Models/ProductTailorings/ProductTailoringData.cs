using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringData : IProductTailoringData
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public ILocalizedString Slug { get; set; }

        public IList<IProductVariantTailoring> Variants { get; set; }
        public IEnumerable<IProductVariantTailoring> VariantsEnumerable { set => Variants = value.ToList(); }

    }
}
