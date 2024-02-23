using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeStateSetMessage))]
    public partial interface IOrderDiscountCodeStateSetMessage : IOrderMessage
    {
        IDiscountCodeReference DiscountCode { get; set; }

        IDiscountCodeState State { get; set; }

        IDiscountCodeState OldState { get; set; }

    }
}
