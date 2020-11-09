using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeInputHintAction))]
    public partial interface IProductTypeChangeInputHintAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        string NewValue { get; set;}
        
        TextInputHint NewValueAsEnum { get; }
    }
}
