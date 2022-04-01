using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    public partial class TaxCategoryUpdate : ITaxCategoryUpdate
    {
        public long Version { get; set; }

        public List<ITaxCategoryUpdateAction> Actions { get; set; }
    }
}
