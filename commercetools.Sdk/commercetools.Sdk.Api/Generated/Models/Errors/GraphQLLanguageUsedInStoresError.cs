namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLLanguageUsedInStoresError : IGraphQLLanguageUsedInStoresError
    {
        public string Code { get; set; }
        public GraphQLLanguageUsedInStoresError()
        {
            this.Code = "LanguageUsedInStores";
        }
    }
}
