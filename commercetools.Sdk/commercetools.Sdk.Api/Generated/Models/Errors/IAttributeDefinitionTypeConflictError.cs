using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.AttributeDefinitionTypeConflictError))]
    public partial interface IAttributeDefinitionTypeConflictError : IErrorObject
    {
        string ConflictingProductTypeId { get; set;}
        
        string ConflictingProductTypeName { get; set;}
        
        string ConflictingAttributeName { get; set;}
    }
}
