using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    public partial class TaxCategoryDraft : ITaxCategoryDraft
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<ITaxRateDraft> Rates { get; set; }

        public string Key { get; set; }
    }
}
