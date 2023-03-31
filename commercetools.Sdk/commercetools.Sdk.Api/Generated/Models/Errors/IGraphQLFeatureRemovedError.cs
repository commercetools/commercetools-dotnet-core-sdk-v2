using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLFeatureRemovedError))]
    public partial interface IGraphQLFeatureRemovedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
