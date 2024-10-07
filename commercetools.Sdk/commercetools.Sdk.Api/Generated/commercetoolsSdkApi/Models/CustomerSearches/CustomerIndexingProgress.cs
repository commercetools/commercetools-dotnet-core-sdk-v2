

namespace commercetools.Sdk.Api.Models.CustomerSearches
{

    public partial class CustomerIndexingProgress : ICustomerIndexingProgress
    {
        public int Indexed { get; set; }

        public int Failed { get; set; }

        public int EstimatedTotal { get; set; }
    }
}
