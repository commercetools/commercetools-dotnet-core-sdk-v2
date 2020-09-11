using commercetools.Api.Models.Errors;
using commercetools.Api.Models.Products;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Errors
{
    public class DuplicateAttributeValuesError : ErrorObject
    {
        public List<Attribute> Attributes { get; set;}
    }
}
