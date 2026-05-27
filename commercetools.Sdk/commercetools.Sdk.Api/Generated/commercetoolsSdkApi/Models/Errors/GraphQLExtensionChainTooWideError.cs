namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExtensionChainTooWideError : IGraphQLExtensionChainTooWideError
    {
        public string Code { get; set; }
        public GraphQLExtensionChainTooWideError()
        {
            this.Code = "ExtensionChainTooWide";
        }
    }
}
