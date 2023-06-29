using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Stores.StoreUpdateAction))]
    [SubTypeDiscriminator("addCountry", typeof(commercetools.Sdk.Api.Models.Stores.StoreAddCountryAction))]
    [SubTypeDiscriminator("addDistributionChannel", typeof(commercetools.Sdk.Api.Models.Stores.StoreAddDistributionChannelAction))]
    [SubTypeDiscriminator("addProductSelection", typeof(commercetools.Sdk.Api.Models.Stores.StoreAddProductSelectionAction))]
    [SubTypeDiscriminator("addSupplyChannel", typeof(commercetools.Sdk.Api.Models.Stores.StoreAddSupplyChannelAction))]
    [SubTypeDiscriminator("changeProductSelectionActive", typeof(commercetools.Sdk.Api.Models.Stores.StoreChangeProductSelectionAction))]
    [SubTypeDiscriminator("removeCountry", typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveCountryAction))]
    [SubTypeDiscriminator("removeDistributionChannel", typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveDistributionChannelAction))]
    [SubTypeDiscriminator("removeProductSelection", typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveProductSelectionAction))]
    [SubTypeDiscriminator("removeSupplyChannel", typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveSupplyChannelAction))]
    [SubTypeDiscriminator("setCountries", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCountriesAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCustomTypeAction))]
    [SubTypeDiscriminator("setDistributionChannels", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetDistributionChannelsAction))]
    [SubTypeDiscriminator("setLanguages", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetLanguagesAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetNameAction))]
    [SubTypeDiscriminator("setProductSelections", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetProductSelectionsAction))]
    [SubTypeDiscriminator("setSupplyChannels", typeof(commercetools.Sdk.Api.Models.Stores.StoreSetSupplyChannelsAction))]
    public partial interface IStoreUpdateAction
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.Stores.StoreAddCountryAction AddCountry(Action<commercetools.Sdk.Api.Models.Stores.StoreAddCountryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreAddCountryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreAddDistributionChannelAction AddDistributionChannel(Action<commercetools.Sdk.Api.Models.Stores.StoreAddDistributionChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreAddDistributionChannelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreAddProductSelectionAction AddProductSelection(Action<commercetools.Sdk.Api.Models.Stores.StoreAddProductSelectionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreAddProductSelectionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreAddSupplyChannelAction AddSupplyChannel(Action<commercetools.Sdk.Api.Models.Stores.StoreAddSupplyChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreAddSupplyChannelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreChangeProductSelectionAction ChangeProductSelectionActive(Action<commercetools.Sdk.Api.Models.Stores.StoreChangeProductSelectionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreChangeProductSelectionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreRemoveCountryAction RemoveCountry(Action<commercetools.Sdk.Api.Models.Stores.StoreRemoveCountryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreRemoveCountryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreRemoveDistributionChannelAction RemoveDistributionChannel(Action<commercetools.Sdk.Api.Models.Stores.StoreRemoveDistributionChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreRemoveDistributionChannelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreRemoveProductSelectionAction RemoveProductSelection(Action<commercetools.Sdk.Api.Models.Stores.StoreRemoveProductSelectionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreRemoveProductSelectionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreRemoveSupplyChannelAction RemoveSupplyChannel(Action<commercetools.Sdk.Api.Models.Stores.StoreRemoveSupplyChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreRemoveSupplyChannelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreSetCountriesAction SetCountries(Action<commercetools.Sdk.Api.Models.Stores.StoreSetCountriesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreSetCountriesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Stores.StoreSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Stores.StoreSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreSetDistributionChannelsAction SetDistributionChannels(Action<commercetools.Sdk.Api.Models.Stores.StoreSetDistributionChannelsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreSetDistributionChannelsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreSetLanguagesAction SetLanguages(Action<commercetools.Sdk.Api.Models.Stores.StoreSetLanguagesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreSetLanguagesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreSetNameAction SetName(Action<commercetools.Sdk.Api.Models.Stores.StoreSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreSetProductSelectionsAction SetProductSelections(Action<commercetools.Sdk.Api.Models.Stores.StoreSetProductSelectionsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreSetProductSelectionsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Stores.StoreSetSupplyChannelsAction SetSupplyChannels(Action<commercetools.Sdk.Api.Models.Stores.StoreSetSupplyChannelsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Stores.StoreSetSupplyChannelsAction();
            init?.Invoke(t);
            return t;
        }
    }
}
