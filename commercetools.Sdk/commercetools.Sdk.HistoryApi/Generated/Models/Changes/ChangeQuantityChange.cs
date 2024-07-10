using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeQuantityChange : IChangeQuantityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IInventoryQuantityValue PreviousValue { get; set; }

        public IInventoryQuantityValue NextValue { get; set; }
        public ChangeQuantityChange()
        {
            this.Type = "ChangeQuantityChange";
        }
    }
}
