using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeLineItemNameChange : IChangeLineItemNameChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShoppingListLineItemValue LineItem { get; set; }

        public ILocalizedString PreviousValue { get; set; }

        public ILocalizedString NextValue { get; set; }
        public ChangeLineItemNameChange()
        {
            this.Type = "ChangeLineItemNameChange";
        }
    }
}
