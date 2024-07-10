using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeProductSelectionActiveChange : IChangeProductSelectionActiveChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference ProductSelection { get; set; }

        public bool PreviousValue { get; set; }

        public bool NextValue { get; set; }
        public ChangeProductSelectionActiveChange()
        {
            this.Type = "ChangeProductSelectionActiveChange";
        }
    }
}
