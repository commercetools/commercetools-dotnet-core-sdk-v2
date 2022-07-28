using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessagePayload))]
    public partial interface IOrderDiscountCodeRemovedMessagePayload : IOrderMessagePayload
    {
        IDiscountCodeReference DiscountCode { get; set; }

    }
}
