using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountCreatedMessagePayload))]
    public partial interface ICartDiscountCreatedMessagePayload : IMessagePayload
    {
        ICartDiscount CartDiscount { get; set; }

    }
}
