namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLBulkOperationMaxItemsExceededError : IGraphQLBulkOperationMaxItemsExceededError
    {
        public string Code { get; set; }

        public int Limit { get; set; }

        public int Provided { get; set; }
        public GraphQLBulkOperationMaxItemsExceededError()
        {
            this.Code = "BulkOperationMaxItemsExceeded";
        }
    }
}
