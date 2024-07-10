namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExtensionPredicateEvaluationFailedError : IGraphQLExtensionPredicateEvaluationFailedError
    {
        public string Code { get; set; }

        public IErrorByExtension ErrorByExtension { get; set; }
        public GraphQLExtensionPredicateEvaluationFailedError()
        {
            this.Code = "ExtensionPredicateEvaluationFailed";
        }
    }
}
