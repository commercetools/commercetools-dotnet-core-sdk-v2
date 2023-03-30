using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSyntaxErrorError))]
    public partial interface IGraphQLSyntaxErrorError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
