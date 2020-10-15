using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("addAsset")]
    public partial class CategoryAddAssetAction : CategoryUpdateAction
    {
        public AssetDraft Asset { get; set;}
        
        public int Position { get; set;}
        public CategoryAddAssetAction()
        { 
           this.Action = "addAsset";
        }
    }
}
