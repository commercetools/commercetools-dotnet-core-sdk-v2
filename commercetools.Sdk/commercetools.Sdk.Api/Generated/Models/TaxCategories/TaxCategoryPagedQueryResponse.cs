using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    public partial class TaxCategoryPagedQueryResponse : ITaxCategoryPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<ITaxCategory> Results { get; set; }
    }
}
