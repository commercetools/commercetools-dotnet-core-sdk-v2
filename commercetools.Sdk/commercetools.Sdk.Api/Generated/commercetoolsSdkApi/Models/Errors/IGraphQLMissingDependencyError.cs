using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMissingDependencyError))]
    public partial interface IGraphQLMissingDependencyError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
