using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCreatedMessagePayload))]
    public partial interface IOrderCreatedMessagePayload : IOrderMessagePayload
    {
        IOrder Order { get; set; }

    }
}
