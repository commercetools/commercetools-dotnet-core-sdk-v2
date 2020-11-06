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
    [DeserializeAs(typeof(commercetools.Api.Models.Products.Product))]
    public partial interface IProduct : IBaseResource
    {
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
