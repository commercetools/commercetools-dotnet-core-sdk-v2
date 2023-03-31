using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSearchDeactivatedError))]
    public partial interface IGraphQLSearchDeactivatedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
