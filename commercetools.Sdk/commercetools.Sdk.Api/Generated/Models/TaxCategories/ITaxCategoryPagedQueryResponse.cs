using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryPagedQueryResponse))]
    public partial interface ITaxCategoryPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<ITaxCategory> Results { get; set; }
        IEnumerable<ITaxCategory> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
