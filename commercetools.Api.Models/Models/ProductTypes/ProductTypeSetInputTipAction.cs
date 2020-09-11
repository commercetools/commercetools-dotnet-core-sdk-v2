using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductTypes
{
    public class ProductTypeSetInputTipAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public LocalizedString InputTip { get; set;}
    }
}
