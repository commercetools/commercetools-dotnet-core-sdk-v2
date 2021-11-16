using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.NumberField))]
    public partial interface INumberField : ICustomField
    {
        double Value { get; set; }
    }
}
