using commercetools.Api.Models.Errors;
using commercetools.Api.Models.Products;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class DuplicateAttributeValuesError : IDuplicateAttributeValuesError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public List<IAttribute> Attributes { get; set;}
        public DuplicateAttributeValuesError()
        { 
           this.Code = "DuplicateAttributeValues";
        }
    }
}
