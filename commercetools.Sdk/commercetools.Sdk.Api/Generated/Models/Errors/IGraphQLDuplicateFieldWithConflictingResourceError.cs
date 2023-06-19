using commercetools.Sdk.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldWithConflictingResourceError))]
    public partial interface IGraphQLDuplicateFieldWithConflictingResourceError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string Field { get; set; }

        Object DuplicateValue { get; set; }

        IReference ConflictingResource { get; set; }

    }
}
