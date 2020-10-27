using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public  partial class CategoryAddAssetAction : ICategoryAddAssetAction
    {
        public string Action { get; set;}
        
        public IAssetDraft Asset { get; set;}
        
        public int? Position { get; set;}
        public CategoryAddAssetAction()
        { 
           this.Action = "addAsset";
        }
    }
}
