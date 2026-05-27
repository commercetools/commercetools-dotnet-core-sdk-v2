using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionDependencyExistsError))]
    public partial interface IGraphQLExtensionDependencyExistsError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
