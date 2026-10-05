namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExtensionCircularDependencyError : IGraphQLExtensionCircularDependencyError
    {
        public string Code { get; set; }
        public GraphQLExtensionCircularDependencyError()
        {
            this.Code = "ExtensionCircularDependency";
        }
    }
}
