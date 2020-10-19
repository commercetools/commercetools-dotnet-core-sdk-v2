using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("removeAsset")]
    public partial class CategoryRemoveAssetAction : CategoryUpdateAction
    {
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        public CategoryRemoveAssetAction()
        { 
           this.Action = "removeAsset";
        }
    }
}
