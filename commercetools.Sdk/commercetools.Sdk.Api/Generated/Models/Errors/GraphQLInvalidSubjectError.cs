namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidSubjectError : IGraphQLInvalidSubjectError
    {
        public string Code { get; set; }
        public GraphQLInvalidSubjectError()
        {
            this.Code = "InvalidSubject";
        }
    }
}
