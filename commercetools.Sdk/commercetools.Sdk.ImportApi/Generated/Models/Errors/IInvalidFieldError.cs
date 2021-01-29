using commercetools.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidFieldError))]
    public partial interface IInvalidFieldError : IErrorObject
    {
        string Field { get; set;}
        
        Object InvalidValue { get; set;}
        
        List<Object> AllowedValues { get; set;}
    }
}
