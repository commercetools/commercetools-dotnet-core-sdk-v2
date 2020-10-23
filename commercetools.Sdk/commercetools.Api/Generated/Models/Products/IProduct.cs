using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ProductTypes;
using commercetools.Api.Generated.Models.Products;
using commercetools.Api.Generated.Models.Reviews;
using commercetools.Api.Generated.Models.States;
using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProduct : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        IProductTypeReference ProductType { get; set;}
        
        IProductCatalogData MasterData { get; set;}
        
        ITaxCategoryReference TaxCategory { get; set;}
        
        IStateReference State { get; set;}
        
        IReviewRatingStatistics ReviewRatingStatistics { get; set;}
    }
}
