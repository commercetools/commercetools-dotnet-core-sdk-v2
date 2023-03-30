namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInternalConstraintViolatedError : IGraphQLInternalConstraintViolatedError
    {
        public string Code { get; set; }
        public GraphQLInternalConstraintViolatedError()
        {
            this.Code = "InternalConstraintViolated";
        }
    }
}
