using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.AttributeDefinitionTypeConflictError))]
    public partial interface IAttributeDefinitionTypeConflictError : IErrorObject
    {
        string ConflictingProductTypeId { get; set; }

        string ConflictingProductTypeName { get; set; }

        string ConflictingAttributeName { get; set; }
    }
}
