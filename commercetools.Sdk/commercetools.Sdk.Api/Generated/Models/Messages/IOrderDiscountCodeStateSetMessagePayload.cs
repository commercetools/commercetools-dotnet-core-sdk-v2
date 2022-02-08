using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDiscountCodeStateSetMessagePayload))]
    public partial interface IOrderDiscountCodeStateSetMessagePayload : IOrderMessagePayload
    {
        IDiscountCodeReference DiscountCode { get; set; }

        IDiscountCodeState State { get; set; }

        IDiscountCodeState OldState { get; set; }
    }
}
