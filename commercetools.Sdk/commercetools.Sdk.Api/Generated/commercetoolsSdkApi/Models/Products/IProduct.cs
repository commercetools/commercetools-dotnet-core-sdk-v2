using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.Product))]
    public partial interface IProduct : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        IProductTypeReference ProductType { get; set; }

        IProductCatalogData MasterData { get; set; }

        ITaxCategoryReference TaxCategory { get; set; }

        IStateReference State { get; set; }

        IReviewRatingStatistics ReviewRatingStatistics { get; set; }

        IProductPriceModeEnum PriceMode { get; set; }

    }
}
