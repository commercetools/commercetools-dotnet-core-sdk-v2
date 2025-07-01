using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupKeySetMessagePayload))]
    public partial interface IDiscountGroupKeySetMessagePayload : IMessagePayload
    {
        string Key { get; set; }

        string OldKey { get; set; }

    }
}
