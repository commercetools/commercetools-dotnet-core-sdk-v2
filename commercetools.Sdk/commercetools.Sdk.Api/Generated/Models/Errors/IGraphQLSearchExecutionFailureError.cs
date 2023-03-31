using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSearchExecutionFailureError))]
    public partial interface IGraphQLSearchExecutionFailureError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
