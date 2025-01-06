

namespace commercetools.Sdk.Api.Models.BusinessUnitSearches
{

    public partial class BusinessUnitIndexingProgress : IBusinessUnitIndexingProgress
    {
        public int Indexed { get; set; }

        public int Failed { get; set; }

        public int EstimatedTotal { get; set; }
    }
}
