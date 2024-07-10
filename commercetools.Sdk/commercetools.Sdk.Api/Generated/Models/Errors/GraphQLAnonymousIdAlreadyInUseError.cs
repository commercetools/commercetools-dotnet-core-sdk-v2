namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLAnonymousIdAlreadyInUseError : IGraphQLAnonymousIdAlreadyInUseError
    {
        public string Code { get; set; }
        public GraphQLAnonymousIdAlreadyInUseError()
        {
            this.Code = "AnonymousIdAlreadyInUse";
        }
    }
}
