namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLSyntaxErrorError : IGraphQLSyntaxErrorError
    {
        public string Code { get; set; }
        public GraphQLSyntaxErrorError()
        {
            this.Code = "SyntaxError";
        }
    }
}
