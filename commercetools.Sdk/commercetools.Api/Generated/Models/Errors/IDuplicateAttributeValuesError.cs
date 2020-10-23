using commercetools.Api.Generated.Models.Errors;
using commercetools.Api.Generated.Models.Products;
using Attribute = commercetools.Api.Generated.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IDuplicateAttributeValuesError : IErrorObject
    {
        List<IAttribute> Attributes { get; set;}
    }
}
