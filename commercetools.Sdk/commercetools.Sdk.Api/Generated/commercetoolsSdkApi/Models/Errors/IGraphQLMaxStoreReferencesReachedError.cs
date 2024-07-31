using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMaxStoreReferencesReachedError))]
    public partial interface IGraphQLMaxStoreReferencesReachedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
