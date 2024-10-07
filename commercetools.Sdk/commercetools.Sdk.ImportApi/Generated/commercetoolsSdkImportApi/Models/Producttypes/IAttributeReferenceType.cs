using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeReferenceType))]
    public partial interface IAttributeReferenceType : IAttributeType
    {
        IReferenceType ReferenceTypeId { get; set; }

    }
}
