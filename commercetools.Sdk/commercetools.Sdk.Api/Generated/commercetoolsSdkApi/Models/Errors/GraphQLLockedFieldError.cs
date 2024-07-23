namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLLockedFieldError : IGraphQLLockedFieldError
    {
        public string Code { get; set; }

        public string Field { get; set; }
        public GraphQLLockedFieldError()
        {
            this.Code = "LockedField";
        }
    }
}
