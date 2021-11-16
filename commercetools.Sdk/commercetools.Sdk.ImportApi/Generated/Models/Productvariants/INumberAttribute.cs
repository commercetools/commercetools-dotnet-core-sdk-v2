using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.NumberAttribute))]
    public partial interface INumberAttribute : IAttribute
    {
        double Value { get; set; }
    }
}
