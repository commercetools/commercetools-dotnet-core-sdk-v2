using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeReferenceType))]
    public partial interface IAttributeReferenceType : IAttributeType
    {
        IReferenceTypeId ReferenceTypeId { get; set; }
    }
}
