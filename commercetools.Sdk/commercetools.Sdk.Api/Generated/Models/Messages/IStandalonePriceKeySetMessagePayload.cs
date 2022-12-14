using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceKeySetMessagePayload))]
    public partial interface IStandalonePriceKeySetMessagePayload : IMessagePayload
    {
        string Key { get; set; }

        string OldKey { get; set; }

    }
}
