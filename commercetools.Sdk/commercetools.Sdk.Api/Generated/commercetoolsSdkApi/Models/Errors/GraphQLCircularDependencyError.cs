namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLCircularDependencyError : IGraphQLCircularDependencyError
    {
        public string Code { get; set; }
        public GraphQLCircularDependencyError()
        {
            this.Code = "CircularDependency";
        }
    }
}
