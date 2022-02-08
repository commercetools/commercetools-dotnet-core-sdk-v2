using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.MessagesConfigurationDraft))]
    public partial interface IMessagesConfigurationDraft
    {
        bool Enabled { get; set; }

        int DeleteDaysAfterCreation { get; set; }
    }
}
