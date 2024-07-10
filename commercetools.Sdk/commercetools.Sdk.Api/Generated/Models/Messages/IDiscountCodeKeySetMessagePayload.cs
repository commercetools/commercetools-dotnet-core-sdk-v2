using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountCodeKeySetMessagePayload))]
    public partial interface IDiscountCodeKeySetMessagePayload : IMessagePayload
    {
        string Key { get; set; }

        string OldKey { get; set; }

    }
}
