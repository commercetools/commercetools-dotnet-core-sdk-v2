using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
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
