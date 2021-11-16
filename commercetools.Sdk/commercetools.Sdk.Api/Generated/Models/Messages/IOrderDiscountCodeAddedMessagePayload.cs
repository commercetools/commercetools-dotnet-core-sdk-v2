using commercetools.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDiscountCodeAddedMessagePayload))]
    public partial interface IOrderDiscountCodeAddedMessagePayload : IMessagePayload
    {
        IDiscountCodeReference DiscountCode { get; set; }
    }
}
