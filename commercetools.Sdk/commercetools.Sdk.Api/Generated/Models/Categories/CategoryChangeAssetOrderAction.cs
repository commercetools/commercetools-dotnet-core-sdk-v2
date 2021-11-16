using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryChangeAssetOrderAction : ICategoryChangeAssetOrderAction
    {
        public string Action { get; set;}
        
        public List<string> AssetOrder { get; set;}
        public CategoryChangeAssetOrderAction()
        { 
           this.Action = "changeAssetOrder";
        }
    }
}
