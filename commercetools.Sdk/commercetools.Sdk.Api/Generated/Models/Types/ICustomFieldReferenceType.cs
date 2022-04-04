using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.CustomFieldReferenceType))]
    public partial interface ICustomFieldReferenceType : IFieldType
    {
        ICustomFieldReferenceValue ReferenceTypeId { get; set; }
    }
}
