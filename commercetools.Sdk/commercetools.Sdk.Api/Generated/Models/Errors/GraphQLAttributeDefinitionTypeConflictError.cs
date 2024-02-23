namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLAttributeDefinitionTypeConflictError : IGraphQLAttributeDefinitionTypeConflictError
    {
        public string Code { get; set; }

        public string ConflictingProductTypeId { get; set; }

        public string ConflictingProductTypeName { get; set; }

        public string ConflictingAttributeName { get; set; }
        public GraphQLAttributeDefinitionTypeConflictError()
        {
            this.Code = "AttributeDefinitionTypeConflict";
        }
    }
}
