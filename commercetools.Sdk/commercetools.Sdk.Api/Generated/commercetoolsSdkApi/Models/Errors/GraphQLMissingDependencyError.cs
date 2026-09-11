namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMissingDependencyError : IGraphQLMissingDependencyError
    {
        public string Code { get; set; }
        public GraphQLMissingDependencyError()
        {
            this.Code = "MissingDependency";
        }
    }
}
