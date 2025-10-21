using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLRecurringOrderFailureError))]
    public partial interface IGraphQLRecurringOrderFailureError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        Object Details { get; set; }

    }
}
