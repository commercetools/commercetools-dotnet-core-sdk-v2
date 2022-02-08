using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderImportedMessagePayload))]
    public partial interface IOrderImportedMessagePayload : IOrderMessagePayload
    {
        IOrder Order { get; set; }
    }
}
