using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("changeAssetOrder")]
    public partial class CategoryChangeAssetOrderAction : CategoryUpdateAction
    {
        public List<string> AssetOrder { get; set;}
        public CategoryChangeAssetOrderAction()
        { 
           this.Action = "changeAssetOrder";
        }
    }
}
