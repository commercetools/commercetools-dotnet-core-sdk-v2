using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Warnings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class Product : IProduct
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public IProductTypeReference ProductType { get; set; }

        public IProductCatalogData MasterData { get; set; }

        public ITaxCategoryReference TaxCategory { get; set; }

        public IStateReference State { get; set; }

        public IReviewRatingStatistics ReviewRatingStatistics { get; set; }

        public IProductPriceModeEnum PriceMode { get; set; }

        public IList<IWarningObject> Warnings { get; set; }

        public IEnumerable<IWarningObject> WarningsEnumerable { set => Warnings = value.ToList(); }
    }
}
