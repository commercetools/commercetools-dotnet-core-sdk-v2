namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLRequiredFieldError : IGraphQLRequiredFieldError
    {
        public string Code { get; set; }

        public string Field { get; set; }
        public GraphQLRequiredFieldError()
        {
            this.Code = "RequiredField";
        }
    }
}
