using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidOperationError))]
    public partial interface IGraphQLInvalidOperationError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
