using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeAddLocalizedEnumValueAction))]
    public partial interface ITypeAddLocalizedEnumValueAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ICustomFieldLocalizedEnumValue Value { get; set; }

    }
}
