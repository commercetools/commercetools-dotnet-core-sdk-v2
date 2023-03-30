using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLGeneralError))]
    public partial interface IGraphQLGeneralError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
