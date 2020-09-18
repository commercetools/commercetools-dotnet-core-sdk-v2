using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("setAssetCustomType")]
    public class CategorySetAssetCustomTypeAction : CategoryUpdateAction
    {
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
    }
}
