using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxRate))]
    public partial interface ITaxRate
    {
        string Id { get; set; }

        string Name { get; set; }

        double Amount { get; set; }

        bool IncludedInPrice { get; set; }

        string Country { get; set; }

        string State { get; set; }

        List<ISubRate> SubRates { get; set; }
    }
}
