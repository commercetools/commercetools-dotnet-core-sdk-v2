using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ShippingMethodChangeTaxCategoryChange : IShippingMethodChangeTaxCategoryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference PreviousValue { get; set; }

        public IReference NextValue { get; set; }
        public ShippingMethodChangeTaxCategoryChange()
        {
            this.Type = "ShippingMethodChangeTaxCategoryChange";
        }
    }
}
