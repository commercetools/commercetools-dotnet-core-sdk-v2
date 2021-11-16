using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeAddLocalizedEnumValueAction))]
    public partial interface ITypeAddLocalizedEnumValueAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ICustomFieldLocalizedEnumValue Value { get; set; }
    }
}
