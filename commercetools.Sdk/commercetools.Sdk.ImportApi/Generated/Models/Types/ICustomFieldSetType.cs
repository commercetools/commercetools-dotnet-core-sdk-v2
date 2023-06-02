using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldSetType))]
    public partial interface ICustomFieldSetType : IFieldType
    {
        IFieldType ElementType { get; set; }

    }
}
