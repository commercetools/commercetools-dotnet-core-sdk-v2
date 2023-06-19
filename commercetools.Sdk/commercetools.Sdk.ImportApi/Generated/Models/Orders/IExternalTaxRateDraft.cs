using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ExternalTaxRateDraft))]
    public partial interface IExternalTaxRateDraft
    {
        string Name { get; set; }

        decimal? Amount { get; set; }

        string Country { get; set; }

        string State { get; set; }

        IList<ISubRate> SubRates { get; set; }
        IEnumerable<ISubRate> SubRatesEnumerable { set => SubRates = value.ToList(); }


        bool? IncludedInPrice { get; set; }

    }
}
