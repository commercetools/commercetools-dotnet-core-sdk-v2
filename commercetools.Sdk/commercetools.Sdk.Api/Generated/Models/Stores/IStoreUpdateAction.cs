using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Stores.StoreUpdateAction))]
    [SubTypeDiscriminator("addDistributionChannel", typeof(commercetools.Api.Models.Stores.StoreAddDistributionChannelAction))]
    [SubTypeDiscriminator("addProductSelection", typeof(commercetools.Api.Models.Stores.StoreAddProductSelectionAction))]
    [SubTypeDiscriminator("addSupplyChannel", typeof(commercetools.Api.Models.Stores.StoreAddSupplyChannelAction))]
    [SubTypeDiscriminator("changeProductSelectionActive", typeof(commercetools.Api.Models.Stores.StoreChangeProductSelectionAction))]
    [SubTypeDiscriminator("removeDistributionChannel", typeof(commercetools.Api.Models.Stores.StoreRemoveDistributionChannelAction))]
    [SubTypeDiscriminator("removeProductSelection", typeof(commercetools.Api.Models.Stores.StoreRemoveProductSelectionAction))]
    [SubTypeDiscriminator("removeSupplyChannel", typeof(commercetools.Api.Models.Stores.StoreRemoveSupplyChannelAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Stores.StoreSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Stores.StoreSetCustomTypeAction))]
    [SubTypeDiscriminator("setDistributionChannels", typeof(commercetools.Api.Models.Stores.StoreSetDistributionChannelsAction))]
    [SubTypeDiscriminator("setLanguages", typeof(commercetools.Api.Models.Stores.StoreSetLanguagesAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Api.Models.Stores.StoreSetNameAction))]
    [SubTypeDiscriminator("setProductSelections", typeof(commercetools.Api.Models.Stores.StoreSetProductSelectionsAction))]
    [SubTypeDiscriminator("setSupplyChannels", typeof(commercetools.Api.Models.Stores.StoreSetSupplyChannelsAction))]
    public partial interface IStoreUpdateAction
    {
        string Action { get; set; }
    }
}
