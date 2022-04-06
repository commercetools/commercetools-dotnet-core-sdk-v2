using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.NumberField))]
    public partial interface INumberField : ICustomField
    {
        double Value { get; set; }
    }
}
