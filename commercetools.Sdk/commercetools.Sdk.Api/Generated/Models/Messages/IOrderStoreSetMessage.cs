using commercetools.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderStoreSetMessage))]
    public partial interface IOrderStoreSetMessage : IOrderMessage
    {
        IStoreKeyReference Store { get; set; }
    }
}
