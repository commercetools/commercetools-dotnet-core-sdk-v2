using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("setAssetCustomType")]
    public partial class CategorySetAssetCustomTypeAction : CategoryUpdateAction
    {
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
        public CategorySetAssetCustomTypeAction()
        { 
           this.Action = "setAssetCustomType";
        }
    }
}
