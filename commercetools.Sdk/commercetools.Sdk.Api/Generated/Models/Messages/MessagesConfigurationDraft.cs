namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class MessagesConfigurationDraft : IMessagesConfigurationDraft
    {
        public bool Enabled { get; set; }

        public int DeleteDaysAfterCreation { get; set; }
    }
}
