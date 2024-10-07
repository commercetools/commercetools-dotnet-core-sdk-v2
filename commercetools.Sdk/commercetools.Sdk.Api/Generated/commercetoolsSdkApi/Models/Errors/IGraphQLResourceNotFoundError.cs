using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLResourceNotFoundError))]
    public partial interface IGraphQLResourceNotFoundError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
