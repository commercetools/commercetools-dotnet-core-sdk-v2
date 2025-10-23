

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetPasswordChange : ISetPasswordChange
    {
        public string Type { get; set; }

        public string Change { get; set; }
        public SetPasswordChange()
        {
            this.Type = "SetPasswordChange";
        }
    }
}
