

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class TaxedPrice : ITaxedPrice
    {
        public IMoney TotalNet { get; set; }

        public IMoney TotalGross { get; set; }
    }
}
