using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderDeletedMessagePayload))]
    public partial interface IOrderDeletedMessagePayload : IOrderMessagePayload
    {
        IOrder Order { get; set; }
    }
}
