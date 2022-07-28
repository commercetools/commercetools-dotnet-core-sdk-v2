using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderStoreSetMessagePayload))]
    public partial interface IOrderStoreSetMessagePayload : IOrderMessagePayload
    {
        IStoreKeyReference Store { get; set; }

    }
}
