using commercetools.Api.Models.Errors;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.AttributeDefinitionAlreadyExistsError))]
    public partial interface IAttributeDefinitionAlreadyExistsError : IErrorObject
    {
        string ConflictingProductTypeId { get; set;}
        
        string ConflictingProductTypeName { get; set;}
        
        string ConflictingAttributeName { get; set;}
    }
}
