using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.MessagesConfiguration))]
    public partial interface IMessagesConfiguration
    {
        bool Enabled { get; set; }

        int? DeleteDaysAfterCreation { get; set; }
    }
}
