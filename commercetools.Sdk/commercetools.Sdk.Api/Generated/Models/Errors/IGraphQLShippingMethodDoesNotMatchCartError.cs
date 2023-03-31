using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLShippingMethodDoesNotMatchCartError))]
    public partial interface IGraphQLShippingMethodDoesNotMatchCartError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
