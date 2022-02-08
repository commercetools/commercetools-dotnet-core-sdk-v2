using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.MessagesConfiguration))]
    public partial interface IMessagesConfiguration
    {
        bool Enabled { get; set; }

        int? DeleteDaysAfterCreation { get; set; }
    }
}
