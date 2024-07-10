namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLSearchDeactivatedError : IGraphQLSearchDeactivatedError
    {
        public string Code { get; set; }
        public GraphQLSearchDeactivatedError()
        {
            this.Code = "SearchDeactivated";
        }
    }
}
