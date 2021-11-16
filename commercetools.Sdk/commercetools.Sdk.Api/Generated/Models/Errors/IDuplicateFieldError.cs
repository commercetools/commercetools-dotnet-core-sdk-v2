using commercetools.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.DuplicateFieldError))]
    public partial interface IDuplicateFieldError : IErrorObject
    {
        string Field { get; set;}
        
        Object DuplicateValue { get; set;}
        
        IReference ConflictingResource { get; set;}
    }
}
