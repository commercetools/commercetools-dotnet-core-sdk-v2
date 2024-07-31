using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceActiveChangedMessagePayload))]
    public partial interface IStandalonePriceActiveChangedMessagePayload : IMessagePayload
    {
        bool Active { get; set; }

        bool OldActive { get; set; }

    }
}
