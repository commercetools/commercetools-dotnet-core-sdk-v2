namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidCurrentPasswordError : IGraphQLInvalidCurrentPasswordError
    {
        public string Code { get; set; }
        public GraphQLInvalidCurrentPasswordError()
        {
            this.Code = "InvalidCurrentPassword";
        }
    }
}
