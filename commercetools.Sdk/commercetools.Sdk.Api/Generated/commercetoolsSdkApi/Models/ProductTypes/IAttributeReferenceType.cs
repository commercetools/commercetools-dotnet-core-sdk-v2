using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeReferenceType))]
    public partial interface IAttributeReferenceType : IAttributeType
    {
        IAttributeReferenceTypeId ReferenceTypeId { get; set; }

    }
}
