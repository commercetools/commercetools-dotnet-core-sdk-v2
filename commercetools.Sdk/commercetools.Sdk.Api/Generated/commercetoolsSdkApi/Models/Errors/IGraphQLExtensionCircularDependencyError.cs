using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionCircularDependencyError))]
    public partial interface IGraphQLExtensionCircularDependencyError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
