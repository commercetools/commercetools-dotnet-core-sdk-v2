namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExtensionNoResponseError : IGraphQLExtensionNoResponseError
    {
        public string Code { get; set; }

        public string ExtensionId { get; set; }

        public string ExtensionKey { get; set; }
        public GraphQLExtensionNoResponseError()
        {
            this.Code = "ExtensionNoResponse";
        }
    }
}
