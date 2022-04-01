using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.CustomFieldSetType))]
    public partial interface ICustomFieldSetType : IFieldType
    {
        IFieldType ElementType { get; set; }
    }
}
