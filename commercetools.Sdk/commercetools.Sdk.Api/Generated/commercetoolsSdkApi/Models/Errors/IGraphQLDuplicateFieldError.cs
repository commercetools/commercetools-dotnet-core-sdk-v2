using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldError))]
    public partial interface IGraphQLDuplicateFieldError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string Field { get; set; }

        Object DuplicateValue { get; set; }

    }
}
