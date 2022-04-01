using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderImportedMessagePayload))]
    public partial interface IOrderImportedMessagePayload : IOrderMessagePayload
    {
        IOrder Order { get; set; }
    }
}
