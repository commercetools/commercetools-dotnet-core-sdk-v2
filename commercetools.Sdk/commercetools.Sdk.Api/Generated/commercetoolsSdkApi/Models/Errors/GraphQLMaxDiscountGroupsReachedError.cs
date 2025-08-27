namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMaxDiscountGroupsReachedError : IGraphQLMaxDiscountGroupsReachedError
    {
        public string Code { get; set; }
        public GraphQLMaxDiscountGroupsReachedError()
        {
            this.Code = "MaxDiscountGroupsReached";
        }
    }
}
