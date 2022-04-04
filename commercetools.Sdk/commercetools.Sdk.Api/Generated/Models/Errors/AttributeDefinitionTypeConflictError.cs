namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class AttributeDefinitionTypeConflictError : IAttributeDefinitionTypeConflictError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ConflictingProductTypeId { get; set; }

        public string ConflictingProductTypeName { get; set; }

        public string ConflictingAttributeName { get; set; }
        public AttributeDefinitionTypeConflictError()
        {
            this.Code = "AttributeDefinitionTypeConflict";
        }
    }
}
