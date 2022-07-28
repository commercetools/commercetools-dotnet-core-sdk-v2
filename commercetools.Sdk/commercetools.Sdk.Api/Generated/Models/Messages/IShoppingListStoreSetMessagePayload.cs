using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ShoppingListStoreSetMessagePayload))]
    public partial interface IShoppingListStoreSetMessagePayload : IMessagePayload
    {
        IStoreKeyReference Store { get; set; }

    }
}
