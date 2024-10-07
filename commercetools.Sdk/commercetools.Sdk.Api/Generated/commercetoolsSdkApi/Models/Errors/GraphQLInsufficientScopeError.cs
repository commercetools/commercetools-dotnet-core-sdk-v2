namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInsufficientScopeError : IGraphQLInsufficientScopeError
    {
        public string Code { get; set; }
        public GraphQLInsufficientScopeError()
        {
            this.Code = "insufficient_scope";
        }
    }
}
