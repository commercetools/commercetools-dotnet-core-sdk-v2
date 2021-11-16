using commercetools.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDiscountCodeAddedMessage))]
    public partial interface IOrderDiscountCodeAddedMessage : IMessage
    {
        IDiscountCodeReference DiscountCode { get; set; }
    }
}
