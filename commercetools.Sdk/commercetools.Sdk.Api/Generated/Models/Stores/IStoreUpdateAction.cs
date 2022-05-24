using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Stores.StoreUpdateAction))]
    [SubTypeDiscriminator("addDistributionChannel", typeof(commercetools.Sdk.Api.Models.Stores.StoreAddDistributionChannelAction))]
    [SubTypeDiscriminator("addProductSelection", typeof(commercetools.Sdk.Api.Models.Stores.StoreAddProductSelectionAction))]
    [SubTypeDiscriminator("addSupplyChannel", typeof(commercetools.Sdk.Api.Models.Stores.StoreAddSupplyChannelAction))]
    [SubTypeDiscriminator("changeProductSelectionActive", typeof(commercetools.Sdk.Api.Models.Stores.StoreChangeProductSelectionAction))]
    [SubTypeDiscriminator("removeDistributionChannel", typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveDistributionChannelAction))]
    [SubTypeDiscriminator("removeProductSelection", typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveProductSelectionAction))]
    [SubTypeDiscriminator("removeSupplyChannel", typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveSupplyChannelAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCustomTypeAction))]
    [SubTypeDiscriminator("setDistributionChannels", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetDistributionChannelsAction))]
    [SubTypeDiscriminator("setLanguages", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetLanguagesAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetNameAction))]
    [SubTypeDiscriminator("setProductSelections", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetProductSelectionsAction))]
    [SubTypeDiscriminator("setSupplyChannels", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetSupplyChannelsAction))]
    public partial interface IStoreUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IStoreUpdateAction>
    {
        new string Action { get; set; }
    }
}
