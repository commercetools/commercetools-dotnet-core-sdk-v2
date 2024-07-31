using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLAnonymousIdAlreadyInUseError))]
    public partial interface IGraphQLAnonymousIdAlreadyInUseError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
