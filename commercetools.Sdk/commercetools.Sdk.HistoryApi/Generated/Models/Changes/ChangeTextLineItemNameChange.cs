using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeTextLineItemNameChange : IChangeTextLineItemNameChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString PreviousValue { get; set; }

        public ILocalizedString NextValue { get; set; }

        public ITextLineItemValue TextLineItem { get; set; }
        public ChangeTextLineItemNameChange()
        {
            this.Type = "ChangeTextLineItemNameChange";
        }
    }
}
