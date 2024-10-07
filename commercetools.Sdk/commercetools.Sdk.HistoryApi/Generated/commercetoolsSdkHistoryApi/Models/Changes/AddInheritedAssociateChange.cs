using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddInheritedAssociateChange : IAddInheritedAssociateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IInheritedAssociate NextValue { get; set; }
        public AddInheritedAssociateChange()
        {
            this.Type = "AddInheritedAssociateChange";
        }
    }
}
