namespace commercetools.Api.Models.Errors
{
    public partial class AttributeDefinitionAlreadyExistsError : IAttributeDefinitionAlreadyExistsError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ConflictingProductTypeId { get; set; }

        public string ConflictingProductTypeName { get; set; }

        public string ConflictingAttributeName { get; set; }
        public AttributeDefinitionAlreadyExistsError()
        {
            this.Code = "AttributeDefinitionAlreadyExists";
        }
    }
}
