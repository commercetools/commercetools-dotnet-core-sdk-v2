namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidOperationError : IGraphQLInvalidOperationError
    {
        public string Code { get; set; }
        public GraphQLInvalidOperationError()
        {
            this.Code = "InvalidOperation";
        }
    }
}
