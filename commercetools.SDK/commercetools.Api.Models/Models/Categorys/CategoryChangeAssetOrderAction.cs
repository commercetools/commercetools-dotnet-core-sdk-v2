using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("changeAssetOrder")]
    public partial class CategoryChangeAssetOrderAction : CategoryUpdateAction
    {
        public List<string> AssetOrder { get; set;}
        public CategoryChangeAssetOrderAction()
        { 
           this.Action = "changeAssetOrder";
        }
    }
}
