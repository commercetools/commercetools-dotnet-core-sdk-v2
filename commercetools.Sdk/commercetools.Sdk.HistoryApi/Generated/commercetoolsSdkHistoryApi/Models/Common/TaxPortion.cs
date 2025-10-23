

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class TaxPortion : ITaxPortion
    {
        public string Name { get; set; }

        public decimal Rate { get; set; }

        public ICentPrecisionMoney Amount { get; set; }
    }
}
