using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setSearchKeywords")]
    public partial class ProductSetSearchKeywordsAction : ProductUpdateAction
    {
        public SearchKeywords SearchKeywords { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetSearchKeywordsAction()
        { 
           this.Action = "setSearchKeywords";
        }
    }
}
