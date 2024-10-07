using commercetools.Sdk.ImportApi.Models.Productvariants;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValueError))]
    public partial interface IDuplicateAttributeValueError : IErrorObject
    {
        IAttribute Attribute { get; set; }

    }
}
