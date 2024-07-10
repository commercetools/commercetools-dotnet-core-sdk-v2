using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLReferenceExistsError : IGraphQLReferenceExistsError
    {
        public string Code { get; set; }

        public IReferenceTypeId ReferencedBy { get; set; }
        public GraphQLReferenceExistsError()
        {
            this.Code = "ReferenceExists";
        }
    }
}
