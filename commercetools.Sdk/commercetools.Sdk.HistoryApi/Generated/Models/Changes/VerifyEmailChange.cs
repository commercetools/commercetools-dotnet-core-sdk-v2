namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class VerifyEmailChange : IVerifyEmailChange
    {
        public string Type { get; set; }

        public string Change { get; set; }
        public VerifyEmailChange()
        {
            this.Type = "VerifyEmailChange";
        }
    }
}
