namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidJsonInputError : IGraphQLInvalidJsonInputError
    {
        public string Code { get; set; }

        public string DetailedErrorMessage { get; set; }
        public GraphQLInvalidJsonInputError()
        {
            this.Code = "InvalidJsonInput";
        }
    }
}
