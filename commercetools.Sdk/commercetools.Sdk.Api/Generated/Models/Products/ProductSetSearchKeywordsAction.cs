using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetSearchKeywordsAction : IProductSetSearchKeywordsAction
    {
        public string Action { get; set;}
        
        public ISearchKeywords SearchKeywords { get; set;}
        
        public bool? Staged { get; set;}
        public ProductSetSearchKeywordsAction()
        { 
           this.Action = "setSearchKeywords";
        }
    }
}
