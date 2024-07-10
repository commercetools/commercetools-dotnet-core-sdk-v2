using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddAssociateChange : IAddAssociateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAssociate NextValue { get; set; }
        public AddAssociateChange()
        {
            this.Type = "AddAssociateChange";
        }
    }
}
