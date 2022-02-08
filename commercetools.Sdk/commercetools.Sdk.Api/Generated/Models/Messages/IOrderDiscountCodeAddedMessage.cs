using commercetools.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDiscountCodeAddedMessage))]
    public partial interface IOrderDiscountCodeAddedMessage : IOrderMessage
    {
        IDiscountCodeReference DiscountCode { get; set; }
    }
}
