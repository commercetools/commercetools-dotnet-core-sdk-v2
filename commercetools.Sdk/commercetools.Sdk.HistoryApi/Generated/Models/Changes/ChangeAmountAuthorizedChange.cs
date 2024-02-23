using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeAmountAuthorizedChange : IChangeAmountAuthorizedChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IMoney PreviousValue { get; set; }

        public IMoney NextValue { get; set; }
        public ChangeAmountAuthorizedChange()
        {
            this.Type = "ChangeAmountAuthorizedChange";
        }
    }
}
