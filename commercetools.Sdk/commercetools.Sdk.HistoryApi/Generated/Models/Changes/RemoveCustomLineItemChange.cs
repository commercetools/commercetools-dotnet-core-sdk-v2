using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveCustomLineItemChange : IRemoveCustomLineItemChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomLineItem NextValue { get; set; }

        public ICustomLineItem PreviousValue { get; set; }
        public RemoveCustomLineItemChange()
        {
            this.Type = "RemoveCustomLineItemChange";
        }
    }
}
