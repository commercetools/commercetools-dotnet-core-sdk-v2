using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionNoResponseError))]
    public partial interface IGraphQLExtensionNoResponseError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string ExtensionId { get; set; }

        string ExtensionKey { get; set; }

    }
}
