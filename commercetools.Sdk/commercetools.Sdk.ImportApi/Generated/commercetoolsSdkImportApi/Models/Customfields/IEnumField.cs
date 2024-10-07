using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.EnumField))]
    public partial interface IEnumField : ICustomField
    {
        string Value { get; set; }

    }
}
