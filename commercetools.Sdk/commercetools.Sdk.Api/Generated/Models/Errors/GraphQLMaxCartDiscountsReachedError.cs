namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMaxCartDiscountsReachedError : IGraphQLMaxCartDiscountsReachedError
    {
        public string Code { get; set; }
        public GraphQLMaxCartDiscountsReachedError()
        {
            this.Code = "MaxCartDiscountsReached";
        }
    }
}
