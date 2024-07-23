using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMaxResourceLimitExceededError : IGraphQLMaxResourceLimitExceededError
    {
        public string Code { get; set; }

        public IReferenceTypeId ExceededResource { get; set; }
        public GraphQLMaxResourceLimitExceededError()
        {
            this.Code = "MaxResourceLimitExceeded";
        }
    }
}
