using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeChangeEnumValueLabelAction))]
    public partial interface ITypeChangeEnumValueLabelAction : ITypeUpdateAction
    {
        string FieldName { get; set;}
        
        ICustomFieldEnumValue Value { get; set;}
    }
}
