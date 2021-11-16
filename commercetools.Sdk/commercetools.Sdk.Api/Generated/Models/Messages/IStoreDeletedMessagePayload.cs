using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.StoreDeletedMessagePayload))]
    public partial interface IStoreDeletedMessagePayload : IMessagePayload
    {
    }
}
