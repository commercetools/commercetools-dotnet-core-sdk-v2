using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessage))]
    public partial interface IOrderStoreSetMessage : IOrderMessage
    {
        IStoreKeyReference Store { get; set; }

    }
}
