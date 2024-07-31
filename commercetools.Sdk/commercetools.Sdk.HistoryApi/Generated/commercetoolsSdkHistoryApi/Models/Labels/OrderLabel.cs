

namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class OrderLabel : IOrderLabel
    {
        public string Type { get; set; }

        public string CustomerEmail { get; set; }

        public string OrderNumber { get; set; }
        public OrderLabel()
        {
            this.Type = "OrderLabel";
        }
    }
}
