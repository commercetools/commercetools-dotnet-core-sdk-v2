using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.AttributeDefinitionAlreadyExistsError))]
    public partial interface IAttributeDefinitionAlreadyExistsError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string ConflictingProductTypeId { get; set; }

        string ConflictingProductTypeName { get; set; }

        string ConflictingAttributeName { get; set; }

    }
}
