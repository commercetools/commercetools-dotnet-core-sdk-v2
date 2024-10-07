using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValueError))]
    public partial interface IDuplicateAttributeValueError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IAttribute Attribute { get; set; }

    }
}
