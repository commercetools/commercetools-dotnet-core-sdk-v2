using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.AttributeDefinitionAlreadyExistsError))]
    public partial interface IAttributeDefinitionAlreadyExistsError : IErrorObject
    {
        string ConflictingProductTypeId { get; set;}
        
        string ConflictingProductTypeName { get; set;}
        
        string ConflictingAttributeName { get; set;}
    }
}
