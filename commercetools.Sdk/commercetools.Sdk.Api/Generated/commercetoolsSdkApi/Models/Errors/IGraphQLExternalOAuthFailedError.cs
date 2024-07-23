using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExternalOAuthFailedError))]
    public partial interface IGraphQLExternalOAuthFailedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
