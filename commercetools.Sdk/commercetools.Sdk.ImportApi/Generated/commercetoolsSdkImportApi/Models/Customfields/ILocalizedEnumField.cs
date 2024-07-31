using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumField))]
    public partial interface ILocalizedEnumField : ICustomField
    {
        string Value { get; set; }

    }
}
