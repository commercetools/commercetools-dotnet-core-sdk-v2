using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.NumberAttribute))]
    public partial interface INumberAttribute : IAttribute
    {
        double Value { get; set; }
    }
}
