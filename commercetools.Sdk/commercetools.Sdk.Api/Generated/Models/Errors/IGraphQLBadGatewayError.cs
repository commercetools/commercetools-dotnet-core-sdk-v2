using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLBadGatewayError))]
    public partial interface IGraphQLBadGatewayError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
