namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class MessagesConfiguration : IMessagesConfiguration
    {
        public bool Enabled { get; set; }

        public int? DeleteDaysAfterCreation { get; set; }
    }
}
