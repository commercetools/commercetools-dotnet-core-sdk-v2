using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("changeCountries", typeof(commercetools.Api.Models.Projects.ProjectChangeCountriesAction))]
    [SubTypeDiscriminator("changeCountryTaxRateFallbackEnabled", typeof(commercetools.Api.Models.Projects.ProjectChangeCountryTaxRateFallbackEnabledAction))]
    [SubTypeDiscriminator("changeCurrencies", typeof(commercetools.Api.Models.Projects.ProjectChangeCurrenciesAction))]
    [SubTypeDiscriminator("changeLanguages", typeof(commercetools.Api.Models.Projects.ProjectChangeLanguagesAction))]
    [SubTypeDiscriminator("changeMessagesConfiguration", typeof(commercetools.Api.Models.Projects.ProjectChangeMessagesConfigurationAction))]
    [SubTypeDiscriminator("changeMessagesEnabled", typeof(commercetools.Api.Models.Projects.ProjectChangeMessagesEnabledAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.Projects.ProjectChangeNameAction))]
    [SubTypeDiscriminator("changeProductSearchIndexingEnabled", typeof(commercetools.Api.Models.Projects.ProjectChangeProductSearchIndexingEnabledAction))]
    [SubTypeDiscriminator("setExternalOAuth", typeof(commercetools.Api.Models.Projects.ProjectSetExternalOAuthAction))]
    [SubTypeDiscriminator("setShippingRateInputType", typeof(commercetools.Api.Models.Projects.ProjectSetShippingRateInputTypeAction))]
    public partial interface IProjectUpdateAction 
    {
        string Action { get; set;}
    }
}
