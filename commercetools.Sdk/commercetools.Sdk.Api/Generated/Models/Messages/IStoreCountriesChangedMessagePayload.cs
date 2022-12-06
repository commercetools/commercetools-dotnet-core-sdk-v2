using commercetools.Sdk.Api.Models.StoreCountries;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCountriesChangedMessagePayload))]
    public partial interface IStoreCountriesChangedMessagePayload : IMessagePayload
    {
        List<IStoreCountry> AddedCountries { get; set; }

        List<IStoreCountry> RemovedCountries { get; set; }

    }
}
