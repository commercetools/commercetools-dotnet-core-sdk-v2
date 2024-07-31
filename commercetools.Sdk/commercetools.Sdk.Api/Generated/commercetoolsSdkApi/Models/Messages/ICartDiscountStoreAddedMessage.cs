using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountStoreAddedMessage))]
    public partial interface ICartDiscountStoreAddedMessage : IMessage
    {
        IStoreKeyReference Store { get; set; }

    }
}
