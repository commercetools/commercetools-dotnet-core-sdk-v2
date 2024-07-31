using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeAddEnumValueAction))]
    public partial interface ITypeAddEnumValueAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ICustomFieldEnumValue Value { get; set; }

    }
}
