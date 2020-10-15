using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("changeAssetName")]
    public partial class CategoryChangeAssetNameAction : CategoryUpdateAction
    {
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public LocalizedString Name { get; set;}
        public CategoryChangeAssetNameAction()
        { 
           this.Action = "changeAssetName";
        }
    }
}
