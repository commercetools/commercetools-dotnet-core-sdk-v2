using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.MessagesConfigurationDraft))]
    public partial interface IMessagesConfigurationDraft
    {
        bool Enabled { get; set; }

        int DeleteDaysAfterCreation { get; set; }

    }
}
