using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEnumValueIsUsedError))]
    public partial interface IGraphQLEnumValueIsUsedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
