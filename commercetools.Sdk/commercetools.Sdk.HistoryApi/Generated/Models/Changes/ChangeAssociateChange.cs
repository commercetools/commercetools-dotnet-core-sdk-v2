using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeAssociateChange : IChangeAssociateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAssociate PreviousValue { get; set; }

        public IAssociate NextValue { get; set; }
        public ChangeAssociateChange()
        {
            this.Type = "ChangeAssociateChange";
        }
    }
}
