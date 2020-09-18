using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("changeAssetOrder")]
    public class CategoryChangeAssetOrderAction : CategoryUpdateAction
    {
        public List<string> AssetOrder { get; set;}
    }
}
