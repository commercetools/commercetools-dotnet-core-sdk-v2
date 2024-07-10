using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAuthenticationModeChange : ISetAuthenticationModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAuthenticationMode PreviousValue { get; set; }

        public IAuthenticationMode NextValue { get; set; }
        public SetAuthenticationModeChange()
        {
            this.Type = "SetAuthenticationModeChange";
        }
    }
}
