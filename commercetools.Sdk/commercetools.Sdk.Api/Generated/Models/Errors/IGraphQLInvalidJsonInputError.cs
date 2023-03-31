using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidJsonInputError))]
    public partial interface IGraphQLInvalidJsonInputError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string DetailedErrorMessage { get; set; }

    }
}
