using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveProductSelectionChange : IRemoveProductSelectionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IProductSelectionSetting PreviousValue { get; set; }
        public RemoveProductSelectionChange()
        {
            this.Type = "RemoveProductSelectionChange";
        }
    }
}
