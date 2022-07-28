using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Prices
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Prices.TaxRate))]
    public partial interface ITaxRate
    {
        string Id { get; set; }

        string Name { get; set; }

        decimal Amount { get; set; }

        bool IncludedInPrice { get; set; }

        string Country { get; set; }

        string State { get; set; }

        List<ISubRate> SubRates { get; set; }

    }
}
