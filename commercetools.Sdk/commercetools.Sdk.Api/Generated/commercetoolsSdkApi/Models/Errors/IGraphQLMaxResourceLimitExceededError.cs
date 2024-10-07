using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMaxResourceLimitExceededError))]
    public partial interface IGraphQLMaxResourceLimitExceededError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IReferenceTypeId ExceededResource { get; set; }

    }
}
