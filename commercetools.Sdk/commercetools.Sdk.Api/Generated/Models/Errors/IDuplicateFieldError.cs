using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicateFieldError))]
    public partial interface IDuplicateFieldError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string Field { get; set; }

        Object DuplicateValue { get; set; }

    }
}
