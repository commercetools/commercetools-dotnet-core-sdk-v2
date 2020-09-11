using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Categorys
{
    public class CategorySetAssetTagsAction : CategoryUpdateAction
    {
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public List<string> Tags { get; set;}
    }
}
