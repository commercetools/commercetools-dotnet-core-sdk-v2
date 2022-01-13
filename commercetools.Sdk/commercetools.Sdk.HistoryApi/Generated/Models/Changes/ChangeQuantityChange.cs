using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeQuantityChange : IChangeQuantityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IInventoryQuantityValue NextValue { get; set; }

        public IInventoryQuantityValue PreviousValue { get; set; }
        public ChangeQuantityChange()
        {
            this.Type = "ChangeQuantityChange";
        }
    }
}
