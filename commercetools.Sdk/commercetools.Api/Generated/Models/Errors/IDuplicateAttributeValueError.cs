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
    public interface IDuplicateAttributeValueError : IErrorObject
    {
        IAttribute Attribute { get; set;}
    }
}
