using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCheckoutUrlTemplateAction))]
    public partial interface IStoreSetCheckoutUrlTemplateAction : IStoreUpdateAction
    {
        string CheckoutUrlTemplate { get; set; }

    }
}
