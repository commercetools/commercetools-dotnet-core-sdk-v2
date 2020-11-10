using commercetools.Api.Models.Errors;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.EnumKeyDoesNotExistError))]
    public partial interface IEnumKeyDoesNotExistError : IErrorObject
    {
        string ConflictingEnumKey { get; set;}
        
        string ConflictingAttributeName { get; set;}
    }
}
