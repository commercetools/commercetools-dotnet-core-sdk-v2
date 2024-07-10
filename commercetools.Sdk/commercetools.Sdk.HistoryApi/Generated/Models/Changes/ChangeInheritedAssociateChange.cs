using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeInheritedAssociateChange : IChangeInheritedAssociateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IInheritedAssociate PreviousValue { get; set; }

        public IInheritedAssociate NextValue { get; set; }
        public ChangeInheritedAssociateChange()
        {
            this.Type = "ChangeInheritedAssociateChange";
        }
    }
}
