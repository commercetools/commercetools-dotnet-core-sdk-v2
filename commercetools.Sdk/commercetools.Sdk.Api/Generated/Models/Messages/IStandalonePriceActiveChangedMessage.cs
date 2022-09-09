using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceActiveChangedMessage))]
    public partial interface IStandalonePriceActiveChangedMessage : IMessage
    {
        bool Active { get; set; }

        bool OldActive { get; set; }

    }
}
