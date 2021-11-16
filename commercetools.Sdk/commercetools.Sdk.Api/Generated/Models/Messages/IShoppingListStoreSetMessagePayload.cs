using commercetools.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ShoppingListStoreSetMessagePayload))]
    public partial interface IShoppingListStoreSetMessagePayload : IMessagePayload
    {
        IStoreKeyReference Store { get; set; }
    }
}
