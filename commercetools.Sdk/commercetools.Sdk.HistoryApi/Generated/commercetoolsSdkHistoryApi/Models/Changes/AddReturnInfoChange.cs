using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddReturnInfoChange : IAddReturnInfoChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReturnInfo NextValue { get; set; }
        public AddReturnInfoChange()
        {
            this.Type = "AddReturnInfoChange";
        }
    }
}
