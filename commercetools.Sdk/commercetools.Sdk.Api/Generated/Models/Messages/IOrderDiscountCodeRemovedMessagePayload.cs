using commercetools.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDiscountCodeRemovedMessagePayload))]
    public partial interface IOrderDiscountCodeRemovedMessagePayload : IOrderMessagePayload
    {
        IDiscountCodeReference DiscountCode { get; set; }
    }
}
