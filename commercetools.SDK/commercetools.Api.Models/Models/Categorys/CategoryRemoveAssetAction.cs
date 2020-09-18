using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("removeAsset")]
    public class CategoryRemoveAssetAction : CategoryUpdateAction
    {
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
    }
}
