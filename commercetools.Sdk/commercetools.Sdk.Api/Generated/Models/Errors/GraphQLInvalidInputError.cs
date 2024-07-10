namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidInputError : IGraphQLInvalidInputError
    {
        public string Code { get; set; }
        public GraphQLInvalidInputError()
        {
            this.Code = "InvalidInput";
        }
    }
}
