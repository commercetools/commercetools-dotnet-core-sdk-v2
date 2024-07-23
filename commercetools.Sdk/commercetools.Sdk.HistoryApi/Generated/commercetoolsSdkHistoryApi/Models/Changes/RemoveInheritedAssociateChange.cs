using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveInheritedAssociateChange : IRemoveInheritedAssociateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IInheritedAssociate PreviousValue { get; set; }
        public RemoveInheritedAssociateChange()
        {
            this.Type = "RemoveInheritedAssociateChange";
        }
    }
}
