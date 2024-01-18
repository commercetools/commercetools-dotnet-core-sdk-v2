namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLNotEnabledError : IGraphQLNotEnabledError
    {
        public string Code { get; set; }
        public GraphQLNotEnabledError()
        {
            this.Code = "NotEnabled";
        }
    }
}
