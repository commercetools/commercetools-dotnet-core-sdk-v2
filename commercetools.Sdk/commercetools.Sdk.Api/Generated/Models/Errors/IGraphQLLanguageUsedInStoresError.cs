using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLLanguageUsedInStoresError))]
    public partial interface IGraphQLLanguageUsedInStoresError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
