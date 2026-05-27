namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExtensionDependencyExistsError : IGraphQLExtensionDependencyExistsError
    {
        public string Code { get; set; }
        public GraphQLExtensionDependencyExistsError()
        {
            this.Code = "ExtensionDependencyExists";
        }
    }
}
