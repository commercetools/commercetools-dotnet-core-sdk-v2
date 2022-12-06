using commercetools.Sdk.Api.Models.StoreCountries;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreCountriesChangedMessagePayload : IStoreCountriesChangedMessagePayload
    {
        public string Type { get; set; }

        public List<IStoreCountry> AddedCountries { get; set; }

        public List<IStoreCountry> RemovedCountries { get; set; }
        public StoreCountriesChangedMessagePayload()
        {
            this.Type = "StoreCountriesChanged";
        }
    }
}
