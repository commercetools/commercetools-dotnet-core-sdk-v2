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
    public partial class ProductTypeChangeLabelAction : IProductTypeChangeLabelAction
    {
        public string Action { get; set;}
        
        public string AttributeName { get; set;}
        
        public ILocalizedString Label { get; set;}
        public ProductTypeChangeLabelAction()
        { 
           this.Action = "changeLabel";
        }
    }
}
