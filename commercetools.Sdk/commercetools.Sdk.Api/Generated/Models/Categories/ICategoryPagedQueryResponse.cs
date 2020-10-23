using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategoryPagedQueryResponse))]
    public interface ICategoryPagedQueryResponse 
    {
        long Limit { get; set;}
        
        long Count { get; set;}
        
        long Total { get; set;}
        
        long Offset { get; set;}
        
        List<ICategory> Results { get; set;}
    }
}
