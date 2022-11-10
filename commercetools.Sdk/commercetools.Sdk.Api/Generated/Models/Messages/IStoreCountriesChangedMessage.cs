using commercetools.Sdk.Api.Models.StoreCountries;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCountriesChangedMessage))]
    public partial interface IStoreCountriesChangedMessage : IMessage
    {
        List<IStoreCountry> AddedCountries { get; set; }

        List<IStoreCountry> RemovedCountries { get; set; }

    }
}
