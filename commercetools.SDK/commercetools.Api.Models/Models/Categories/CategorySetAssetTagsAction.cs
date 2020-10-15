using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("setAssetTags")]
    public partial class CategorySetAssetTagsAction : CategoryUpdateAction
    {
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public List<string> Tags { get; set;}
        public CategorySetAssetTagsAction()
        { 
           this.Action = "setAssetTags";
        }
    }
}
