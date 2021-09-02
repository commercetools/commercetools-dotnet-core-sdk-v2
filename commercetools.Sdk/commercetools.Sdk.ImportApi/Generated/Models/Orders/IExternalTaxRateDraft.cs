using commercetools.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.ExternalTaxRateDraft))]
    public partial interface IExternalTaxRateDraft
    {
        string Name { get; set; }

        double? Amount { get; set; }

        string Country { get; set; }

        string State { get; set; }

        List<ISubRate> SubRates { get; set; }

        bool? IncludedInPrice { get; set; }
    }
}
