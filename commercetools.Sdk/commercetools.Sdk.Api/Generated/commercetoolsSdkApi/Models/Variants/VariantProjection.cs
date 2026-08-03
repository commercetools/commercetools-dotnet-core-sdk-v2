using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantProjection : IVariantProjection
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Staged { get; set; }

        public int VariantId { get; set; }

        public IProductReference Product { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<ICategoryReference> Categories { get; set; }

        public IEnumerable<ICategoryReference> CategoriesEnumerable { set => Categories = value.ToList(); }

        public ICategoryOrderHints CategoryOrderHints { get; set; }

        public string Key { get; set; }

        public string Sku { get; set; }

        public IList<IImage> Images { get; set; }

        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }

        public IList<IAsset> Assets { get; set; }

        public IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        public IPrice Price { get; set; }

        public bool Default { get; set; }
    }
}
