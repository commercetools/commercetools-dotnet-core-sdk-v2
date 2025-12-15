

namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class ShippingMethodLabel : IShippingMethodLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }
        public ShippingMethodLabel()
        {
            this.Type = "ShippingMethodLabel";
        }
    }
}
