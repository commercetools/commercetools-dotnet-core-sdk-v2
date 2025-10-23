using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveShippingChange : IRemoveShippingChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShipping PreviousValue { get; set; }
        public RemoveShippingChange()
        {
            this.Type = "RemoveShippingChange";
        }
    }
}
