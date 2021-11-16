using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidFieldError))]
    public partial interface IInvalidFieldError : IErrorObject
    {
        string Field { get; set;}
        
        Object InvalidValue { get; set;}
        
        List<Object> AllowedValues { get; set;}
        
        long? ResourceIndex { get; set;}
    }
}
