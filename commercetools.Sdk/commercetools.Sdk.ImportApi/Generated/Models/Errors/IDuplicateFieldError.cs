using commercetools.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.DuplicateFieldError))]
    public partial interface IDuplicateFieldError : IErrorObject
    {
        string Field { get; set;}
        
        Object DuplicateValue { get; set;}
    }
}
