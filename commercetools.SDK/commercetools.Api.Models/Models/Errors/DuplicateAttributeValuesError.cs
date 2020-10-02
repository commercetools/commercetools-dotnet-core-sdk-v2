using commercetools.Api.Models.Errors;
using commercetools.Api.Models.Products;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("DuplicateAttributeValues")]
    public partial class DuplicateAttributeValuesError : ErrorObject
    {
        public List<Attribute> Attributes { get; set;}
        public DuplicateAttributeValuesError()
        { 
           this.Code = "DuplicateAttributeValues";
        }
    }
}
