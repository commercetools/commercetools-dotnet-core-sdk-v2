using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveAssociateChange : IRemoveAssociateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAssociate PreviousValue { get; set; }
        public RemoveAssociateChange()
        {
            this.Type = "RemoveAssociateChange";
        }
    }
}
