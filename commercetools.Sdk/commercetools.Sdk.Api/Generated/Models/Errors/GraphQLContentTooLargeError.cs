namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLContentTooLargeError : IGraphQLContentTooLargeError
    {
        public string Code { get; set; }
        public GraphQLContentTooLargeError()
        {
            this.Code = "ContentTooLarge";
        }
    }
}
