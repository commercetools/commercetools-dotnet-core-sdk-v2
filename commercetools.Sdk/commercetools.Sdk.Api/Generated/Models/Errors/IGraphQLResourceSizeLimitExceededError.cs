using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLResourceSizeLimitExceededError))]
    public partial interface IGraphQLResourceSizeLimitExceededError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
