using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceKeySetMessage))]
    public partial interface IStandalonePriceKeySetMessage : IMessage
    {
        string Key { get; set; }

        string OldKey { get; set; }

    }
}
