using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("setAssetCustomField")]
    public partial class CategorySetAssetCustomFieldAction : CategoryUpdateAction
    {
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CategorySetAssetCustomFieldAction()
        { 
           this.Action = "setAssetCustomField";
        }
    }
}
