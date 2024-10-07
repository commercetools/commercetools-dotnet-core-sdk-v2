using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.NumberField))]
    public partial interface INumberField : ICustomField
    {
        decimal Value { get; set; }

    }
}
