using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValueError))]
    public partial interface IDuplicateAttributeValueError : IErrorObject
    {
        IAttribute Attribute { get; set; }
    }
}
