using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeAddedMessagePayload))]
    public partial interface IOrderDiscountCodeAddedMessagePayload : IOrderMessagePayload
    {
        IDiscountCodeReference DiscountCode { get; set; }

    }
}
