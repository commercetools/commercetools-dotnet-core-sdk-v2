using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLPendingOperationError))]
    public partial interface IGraphQLPendingOperationError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
