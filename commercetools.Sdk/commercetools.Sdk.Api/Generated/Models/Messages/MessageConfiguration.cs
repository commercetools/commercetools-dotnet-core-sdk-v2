namespace commercetools.Api.Models.Messages
{
    public partial class MessageConfiguration : IMessageConfiguration
    {
        public bool Enabled { get; set;}
        
        public int? DeleteDaysAfterCreation { get; set;}
    }
}
