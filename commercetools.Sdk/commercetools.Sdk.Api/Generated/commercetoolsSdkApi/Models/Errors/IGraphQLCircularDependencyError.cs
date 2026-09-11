using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLCircularDependencyError))]
    public partial interface IGraphQLCircularDependencyError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
