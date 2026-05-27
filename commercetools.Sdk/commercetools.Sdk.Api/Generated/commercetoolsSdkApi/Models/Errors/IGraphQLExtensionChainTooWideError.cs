using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionChainTooWideError))]
    public partial interface IGraphQLExtensionChainTooWideError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
