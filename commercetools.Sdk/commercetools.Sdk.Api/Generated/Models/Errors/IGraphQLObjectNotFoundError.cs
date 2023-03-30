using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLObjectNotFoundError))]
    public partial interface IGraphQLObjectNotFoundError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
