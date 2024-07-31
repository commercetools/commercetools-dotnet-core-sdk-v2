using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderDiscountCodeRemovedMessage))]
    public partial interface IOrderDiscountCodeRemovedMessage : IOrderMessage
    {
        IDiscountCodeReference DiscountCode { get; set; }

    }
}
