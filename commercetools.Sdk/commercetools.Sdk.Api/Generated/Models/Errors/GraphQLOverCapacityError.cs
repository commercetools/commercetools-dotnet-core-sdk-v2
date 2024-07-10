namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLOverCapacityError : IGraphQLOverCapacityError
    {
        public string Code { get; set; }
        public GraphQLOverCapacityError()
        {
            this.Code = "OverCapacity";
        }
    }
}
