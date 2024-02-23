namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLConcurrentModificationError : IGraphQLConcurrentModificationError
    {
        public string Code { get; set; }

        public long? CurrentVersion { get; set; }
        public GraphQLConcurrentModificationError()
        {
            this.Code = "ConcurrentModification";
        }
    }
}
