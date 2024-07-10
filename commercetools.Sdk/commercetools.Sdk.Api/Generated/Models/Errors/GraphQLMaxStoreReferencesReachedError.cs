namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMaxStoreReferencesReachedError : IGraphQLMaxStoreReferencesReachedError
    {
        public string Code { get; set; }
        public GraphQLMaxStoreReferencesReachedError()
        {
            this.Code = "MaxStoreReferencesReached";
        }
    }
}
