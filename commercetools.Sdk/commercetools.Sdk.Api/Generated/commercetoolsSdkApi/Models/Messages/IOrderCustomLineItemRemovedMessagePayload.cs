using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemRemovedMessagePayload))]
    public partial interface IOrderCustomLineItemRemovedMessagePayload : IOrderMessagePayload
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        ICustomLineItem CustomLineItem { get; set; }

    }
}
