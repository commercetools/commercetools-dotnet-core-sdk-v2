using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSemanticErrorError))]
    public partial interface IGraphQLSemanticErrorError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
