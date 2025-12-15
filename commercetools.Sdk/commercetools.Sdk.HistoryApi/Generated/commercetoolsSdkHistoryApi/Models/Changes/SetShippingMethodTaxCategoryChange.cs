using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShippingMethodTaxCategoryChange : ISetShippingMethodTaxCategoryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxMode TaxMode { get; set; }

        public IReference PreviousValue { get; set; }

        public IReference NextValue { get; set; }
        public SetShippingMethodTaxCategoryChange()
        {
            this.Type = "SetShippingMethodTaxCategoryChange";
        }
    }
}
