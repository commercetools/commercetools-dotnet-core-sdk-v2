using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Projects.ProjectUpdateAction))]
    [SubTypeDiscriminator("changeCartsConfiguration", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCartsConfigurationAction))]
    [SubTypeDiscriminator("changeCountries", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCountriesAction))]
    [SubTypeDiscriminator("changeCountryTaxRateFallbackEnabled", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCountryTaxRateFallbackEnabledAction))]
    [SubTypeDiscriminator("changeCurrencies", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCurrenciesAction))]
    [SubTypeDiscriminator("changeLanguages", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeLanguagesAction))]
    [SubTypeDiscriminator("changeMessagesConfiguration", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeMessagesConfigurationAction))]
    [SubTypeDiscriminator("changeMyBusinessUnitStatusOnCreation", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeBusinessUnitStatusOnCreationAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeNameAction))]
    [SubTypeDiscriminator("changeOrderSearchStatus", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeOrderSearchStatusAction))]
    [SubTypeDiscriminator("changeProductSearchIndexingEnabled", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeProductSearchIndexingEnabledAction))]
    [SubTypeDiscriminator("changeShoppingListsConfiguration", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeShoppingListsConfigurationAction))]
    [SubTypeDiscriminator("setExternalOAuth", typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetExternalOAuthAction))]
    [SubTypeDiscriminator("setShippingRateInputType", typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetShippingRateInputTypeAction))]
    public partial interface IProjectUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IProjectUpdateAction>
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.Projects.ProjectChangeCartsConfigurationAction ChangeCartsConfiguration(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeCartsConfigurationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeCartsConfigurationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeCountriesAction ChangeCountries(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeCountriesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeCountriesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeCountryTaxRateFallbackEnabledAction ChangeCountryTaxRateFallbackEnabled(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeCountryTaxRateFallbackEnabledAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeCountryTaxRateFallbackEnabledAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeCurrenciesAction ChangeCurrencies(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeCurrenciesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeCurrenciesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeLanguagesAction ChangeLanguages(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeLanguagesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeLanguagesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeMessagesConfigurationAction ChangeMessagesConfiguration(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeMessagesConfigurationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeMessagesConfigurationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeBusinessUnitStatusOnCreationAction ChangeMyBusinessUnitStatusOnCreation(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeBusinessUnitStatusOnCreationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeBusinessUnitStatusOnCreationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeOrderSearchStatusAction ChangeOrderSearchStatus(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeOrderSearchStatusAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeOrderSearchStatusAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeProductSearchIndexingEnabledAction ChangeProductSearchIndexingEnabled(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeProductSearchIndexingEnabledAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeProductSearchIndexingEnabledAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectChangeShoppingListsConfigurationAction ChangeShoppingListsConfiguration(Action<commercetools.Sdk.Api.Models.Projects.ProjectChangeShoppingListsConfigurationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectChangeShoppingListsConfigurationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectSetExternalOAuthAction SetExternalOAuth(Action<commercetools.Sdk.Api.Models.Projects.ProjectSetExternalOAuthAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectSetExternalOAuthAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Projects.ProjectSetShippingRateInputTypeAction SetShippingRateInputType(Action<commercetools.Sdk.Api.Models.Projects.ProjectSetShippingRateInputTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Projects.ProjectSetShippingRateInputTypeAction();
            init?.Invoke(t);
            return t;
        }
    }
}
