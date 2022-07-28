using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeLocalizedEnumValueLabelAction))]
    public partial interface ITypeChangeLocalizedEnumValueLabelAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ICustomFieldLocalizedEnumValue Value { get; set; }

    }
}
