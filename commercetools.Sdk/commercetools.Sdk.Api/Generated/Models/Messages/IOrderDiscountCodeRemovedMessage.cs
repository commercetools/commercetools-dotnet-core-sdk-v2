using commercetools.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDiscountCodeRemovedMessage))]
    public partial interface IOrderDiscountCodeRemovedMessage : IOrderMessage
    {
        IDiscountCodeReference DiscountCode { get; set; }
    }
}
