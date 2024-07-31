using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryDraft))]
    public partial interface ITaxCategoryDraft
    {
        string Name { get; set; }

        string Description { get; set; }

        IList<ITaxRateDraft> Rates { get; set; }

        IEnumerable<ITaxRateDraft> RatesEnumerable { set => Rates = value.ToList(); }

        string Key { get; set; }

    }
}
