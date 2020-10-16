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
    [DiscriminatorValue("DuplicateAttributeValue")]
    public partial class DuplicateAttributeValueError : ErrorObject
    {
        public Attribute Attribute { get; set;}
        public DuplicateAttributeValueError()
        { 
           this.Code = "DuplicateAttributeValue";
        }
    }
}
