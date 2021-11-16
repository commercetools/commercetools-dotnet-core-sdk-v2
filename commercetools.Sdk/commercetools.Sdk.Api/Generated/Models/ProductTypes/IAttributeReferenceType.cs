using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributeReferenceType))]
    public partial interface IAttributeReferenceType : IAttributeType
    {
        IReferenceTypeId ReferenceTypeId { get; set;}
    }
}
