using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountStoreAddedMessagePayload))]
    public partial interface ICartDiscountStoreAddedMessagePayload : IMessagePayload
    {
        IStoreKeyReference Store { get; set; }

    }
}
