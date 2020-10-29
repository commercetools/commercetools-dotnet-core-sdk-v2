using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.States;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class Product : IProduct
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public string Key { get; set;}
        
        public IProductTypeReference ProductType { get; set;}
        
        public IProductCatalogData MasterData { get; set;}
        
        public ITaxCategoryReference TaxCategory { get; set;}
        
        public IStateReference State { get; set;}
        
        public IReviewRatingStatistics ReviewRatingStatistics { get; set;}
    }
}
