using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddProductSelectionChange : IAddProductSelectionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IProductSelectionSetting PreviousValue { get; set; }

        public IProductSelectionSetting NextValue { get; set; }
        public AddProductSelectionChange()
        {
            this.Type = "AddProductSelectionChange";
        }
    }
}
