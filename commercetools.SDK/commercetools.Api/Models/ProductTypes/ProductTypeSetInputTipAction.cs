using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("setInputTip")]
    public partial class ProductTypeSetInputTipAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public LocalizedString InputTip { get; set;}
        public ProductTypeSetInputTipAction()
        { 
           this.Action = "setInputTip";
        }
    }
}
