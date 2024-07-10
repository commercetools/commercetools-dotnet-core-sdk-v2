namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLSemanticErrorError : IGraphQLSemanticErrorError
    {
        public string Code { get; set; }
        public GraphQLSemanticErrorError()
        {
            this.Code = "SemanticError";
        }
    }
}
