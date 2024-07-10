namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMoneyOverflowError : IGraphQLMoneyOverflowError
    {
        public string Code { get; set; }
        public GraphQLMoneyOverflowError()
        {
            this.Code = "MoneyOverflow";
        }
    }
}
