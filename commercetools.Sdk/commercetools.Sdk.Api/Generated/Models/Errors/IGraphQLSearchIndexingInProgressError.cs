using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSearchIndexingInProgressError))]
    public partial interface IGraphQLSearchIndexingInProgressError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
