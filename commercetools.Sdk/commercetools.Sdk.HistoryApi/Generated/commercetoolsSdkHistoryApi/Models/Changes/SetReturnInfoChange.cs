using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetReturnInfoChange : ISetReturnInfoChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReturnInfo PreviousValue { get; set; }

        public IReturnInfo NextValue { get; set; }
        public SetReturnInfoChange()
        {
            this.Type = "SetReturnInfoChange";
        }
    }
}
