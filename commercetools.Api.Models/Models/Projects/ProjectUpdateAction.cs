using commercetools.Api.Models.Projects;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Projects
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ProjectChangeCountriesAction), "changeCountries")]
    [JsonSubtypes.KnownSubType(typeof(ProjectChangeCountryTaxRateFallbackEnabledAction), "changeCountryTaxRateFallbackEnabled")]
    [JsonSubtypes.KnownSubType(typeof(ProjectChangeCurrenciesAction), "changeCurrencies")]
    [JsonSubtypes.KnownSubType(typeof(ProjectChangeLanguagesAction), "changeLanguages")]
    [JsonSubtypes.KnownSubType(typeof(ProjectChangeMessagesConfigurationAction), "changeMessagesConfiguration")]
    [JsonSubtypes.KnownSubType(typeof(ProjectChangeMessagesEnabledAction), "changeMessagesEnabled")]
    [JsonSubtypes.KnownSubType(typeof(ProjectChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(ProjectSetExternalOAuthAction), "setExternalOAuth")]
    [JsonSubtypes.KnownSubType(typeof(ProjectSetShippingRateInputTypeAction), "setShippingRateInputType")]
    public abstract class ProjectUpdateAction 
    {
        public string Action { get; set;}
    }
}
