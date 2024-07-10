using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCredentialsError))]
    public partial interface IGraphQLInvalidCredentialsError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
