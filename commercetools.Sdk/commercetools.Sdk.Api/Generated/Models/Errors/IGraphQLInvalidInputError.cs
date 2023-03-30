using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidInputError))]
    public partial interface IGraphQLInvalidInputError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
