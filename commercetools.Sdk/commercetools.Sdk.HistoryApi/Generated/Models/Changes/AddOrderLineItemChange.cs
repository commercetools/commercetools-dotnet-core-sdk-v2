using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class AddOrderLineItemChange : IAddOrderLineItemChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILineItem PreviousValue { get; set; }

        public ILineItem NextValue { get; set; }
        public AddOrderLineItemChange()
        {
            this.Type = "AddOrderLineItemChange";
        }
    }
}
