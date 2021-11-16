using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.CustomFieldSetType))]
    public partial interface ICustomFieldSetType : IFieldType
    {
        IFieldType ElementType { get; set;}
    }
}
