namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLGeneralError : IGraphQLGeneralError
    {
        public string Code { get; set; }
        public GraphQLGeneralError()
        {
            this.Code = "General";
        }
    }
}
