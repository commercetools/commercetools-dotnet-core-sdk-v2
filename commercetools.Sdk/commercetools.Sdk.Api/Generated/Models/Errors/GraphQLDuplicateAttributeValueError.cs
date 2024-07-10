using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLDuplicateAttributeValueError : IGraphQLDuplicateAttributeValueError
    {
        public string Code { get; set; }

        public IAttribute Attribute { get; set; }
        public GraphQLDuplicateAttributeValueError()
        {
            this.Code = "DuplicateAttributeValue";
        }
    }
}
