using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.RecurringOrderFailureError))]
    public partial interface IRecurringOrderFailureError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        Object Details { get; set; }

    }
}
