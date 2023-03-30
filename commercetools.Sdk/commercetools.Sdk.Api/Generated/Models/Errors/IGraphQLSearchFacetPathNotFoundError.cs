using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSearchFacetPathNotFoundError))]
    public partial interface IGraphQLSearchFacetPathNotFoundError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
