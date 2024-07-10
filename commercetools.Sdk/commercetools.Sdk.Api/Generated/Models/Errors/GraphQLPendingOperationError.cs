namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLPendingOperationError : IGraphQLPendingOperationError
    {
        public string Code { get; set; }
        public GraphQLPendingOperationError()
        {
            this.Code = "PendingOperation";
        }
    }
}
