using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionChainTooDeepError))]
    public partial interface IGraphQLExtensionChainTooDeepError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
