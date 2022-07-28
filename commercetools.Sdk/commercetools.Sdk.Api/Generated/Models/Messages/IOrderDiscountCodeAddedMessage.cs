using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessage))]
    public partial interface IOrderDiscountCodeAddedMessage : IOrderMessage
    {
        IDiscountCodeReference DiscountCode { get; set; }

    }
}
