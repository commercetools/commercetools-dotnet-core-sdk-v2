using commercetools.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderStoreSetMessagePayload))]
    public partial interface IOrderStoreSetMessagePayload : IOrderMessagePayload
    {
        IStoreKeyReference Store { get; set; }
    }
}
