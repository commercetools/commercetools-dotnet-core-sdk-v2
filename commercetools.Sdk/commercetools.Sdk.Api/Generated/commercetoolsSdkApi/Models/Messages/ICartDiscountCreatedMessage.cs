using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountCreatedMessage))]
    public partial interface ICartDiscountCreatedMessage : IMessage
    {
        ICartDiscount CartDiscount { get; set; }

    }
}
