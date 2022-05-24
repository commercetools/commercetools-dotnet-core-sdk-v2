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
    [SubTypeDiscriminator("changeMessagesEnabled", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeMessagesEnabledAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeNameAction))]
    [SubTypeDiscriminator("changeOrderSearchStatus", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeOrderSearchStatusAction))]
    [SubTypeDiscriminator("changeProductSearchIndexingEnabled", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeProductSearchIndexingEnabledAction))]
    [SubTypeDiscriminator("changeShoppingListsConfiguration", typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeShoppingListsConfigurationAction))]
    [SubTypeDiscriminator("setExternalOAuth", typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetExternalOAuthAction))]
    [SubTypeDiscriminator("setShippingRateInputType", typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetShippingRateInputTypeAction))]
    public partial interface IProjectUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IProjectUpdateAction>
    {
        new string Action { get; set; }
    }
}
