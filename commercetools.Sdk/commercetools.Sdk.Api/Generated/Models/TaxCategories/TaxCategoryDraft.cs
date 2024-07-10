using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxCategoryDraft : ITaxCategoryDraft
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IList<ITaxRateDraft> Rates { get; set; }
        public IEnumerable<ITaxRateDraft> RatesEnumerable { set => Rates = value.ToList(); }


        public string Key { get; set; }
    }
}
