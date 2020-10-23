using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public  partial class CategorySetAssetKeyAction : ICategorySetAssetKeyAction
    {
        public string Action { get; set;}
        
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        public CategorySetAssetKeyAction()
        { 
           this.Action = "setAssetKey";
        }
    }
}
