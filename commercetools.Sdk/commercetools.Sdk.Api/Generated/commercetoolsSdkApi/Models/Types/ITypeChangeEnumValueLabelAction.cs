using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeEnumValueLabelAction))]
    public partial interface ITypeChangeEnumValueLabelAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ICustomFieldEnumValue Value { get; set; }

    }
}
