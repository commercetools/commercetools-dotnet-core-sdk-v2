using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.DuplicateFieldError))]
    public partial interface IDuplicateFieldError : IErrorObject
    {
        string Field { get; set; }

        Object DuplicateValue { get; set; }

    }
}
