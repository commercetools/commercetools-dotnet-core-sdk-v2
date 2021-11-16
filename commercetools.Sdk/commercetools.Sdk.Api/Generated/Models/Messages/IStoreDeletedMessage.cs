using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.StoreDeletedMessage))]
    public partial interface IStoreDeletedMessage : IMessage
    {
    }
}
