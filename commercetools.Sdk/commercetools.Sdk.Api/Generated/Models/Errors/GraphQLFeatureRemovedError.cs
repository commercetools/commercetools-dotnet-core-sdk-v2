namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLFeatureRemovedError : IGraphQLFeatureRemovedError
    {
        public string Code { get; set; }
        public GraphQLFeatureRemovedError()
        {
            this.Code = "FeatureRemoved";
        }
    }
}
