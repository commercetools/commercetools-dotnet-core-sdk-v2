namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExtensionChainTooDeepError : IGraphQLExtensionChainTooDeepError
    {
        public string Code { get; set; }
        public GraphQLExtensionChainTooDeepError()
        {
            this.Code = "ExtensionChainTooDeep";
        }
    }
}
