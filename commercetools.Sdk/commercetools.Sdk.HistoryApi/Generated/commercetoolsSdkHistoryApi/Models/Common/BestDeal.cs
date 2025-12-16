

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class BestDeal : IBestDeal
    {
        public string Type { get; set; }

        public string ChosenDiscountType { get; set; }
        public BestDeal()
        {
            this.Type = "BestDeal";
        }
    }
}
