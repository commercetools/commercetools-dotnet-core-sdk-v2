using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddShippingChange : IAddShippingChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShipping NextValue { get; set; }
        public AddShippingChange()
        {
            this.Type = "AddShippingChange";
        }
    }
}
