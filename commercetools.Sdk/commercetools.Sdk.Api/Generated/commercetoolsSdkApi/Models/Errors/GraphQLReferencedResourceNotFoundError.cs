using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLReferencedResourceNotFoundError : IGraphQLReferencedResourceNotFoundError
    {
        public string Code { get; set; }

        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public GraphQLReferencedResourceNotFoundError()
        {
            this.Code = "ReferencedResourceNotFound";
        }
    }
}
