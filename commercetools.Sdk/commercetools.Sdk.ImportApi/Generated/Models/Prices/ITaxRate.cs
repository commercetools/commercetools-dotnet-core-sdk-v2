using commercetools.Sdk.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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

        IList<ISubRate> SubRates { get; set; }
        IEnumerable<ISubRate> SubRatesEnumerable { set => SubRates = value.ToList(); }


    }
}
