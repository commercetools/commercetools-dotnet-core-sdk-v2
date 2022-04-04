using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderDeletedMessagePayload))]
    public partial interface IOrderDeletedMessagePayload : IOrderMessagePayload
    {
        IOrder Order { get; set; }
    }
}
