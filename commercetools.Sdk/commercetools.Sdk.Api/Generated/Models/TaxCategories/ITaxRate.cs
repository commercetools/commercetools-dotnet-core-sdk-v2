using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxRate))]
    public partial interface ITaxRate
    {
        string Id { get; set; }

        string Key { get; set; }

        string Name { get; set; }

        decimal Amount { get; set; }

        bool IncludedInPrice { get; set; }

        string Country { get; set; }

        string State { get; set; }

        IList<ISubRate> SubRates { get; set; }
        IEnumerable<ISubRate> SubRatesEnumerable { set => SubRates = value.ToList(); }


    }
}
