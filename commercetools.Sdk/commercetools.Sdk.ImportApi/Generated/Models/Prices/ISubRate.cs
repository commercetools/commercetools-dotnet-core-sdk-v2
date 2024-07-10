using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Prices
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Prices.SubRate))]
    public partial interface ISubRate
    {
        string Name { get; set; }

        decimal Amount { get; set; }

    }
}
