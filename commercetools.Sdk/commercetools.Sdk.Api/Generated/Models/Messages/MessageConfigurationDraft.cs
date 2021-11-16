namespace commercetools.Api.Models.Messages
{
    public partial class MessageConfigurationDraft : IMessageConfigurationDraft
    {
        public bool Enabled { get; set;}
        
        public int DeleteDaysAfterCreation { get; set;}
    }
}
