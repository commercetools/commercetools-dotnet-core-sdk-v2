using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldReferenceType))]
    public partial interface ICustomFieldReferenceType : IFieldType
    {
        ICustomFieldReferenceValue ReferenceTypeId { get; set; }

    }
}
