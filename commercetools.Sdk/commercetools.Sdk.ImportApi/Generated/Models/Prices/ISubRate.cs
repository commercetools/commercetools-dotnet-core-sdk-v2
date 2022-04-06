using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Prices
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Prices.SubRate))]
    public partial interface ISubRate
    {
        string Name { get; set; }

        double Amount { get; set; }
    }
}
