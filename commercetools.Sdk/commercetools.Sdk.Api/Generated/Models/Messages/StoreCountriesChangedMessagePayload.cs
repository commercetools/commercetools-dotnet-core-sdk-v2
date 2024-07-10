using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.StoreCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreCountriesChangedMessagePayload : IStoreCountriesChangedMessagePayload
    {
        public string Type { get; set; }

        public IList<IStoreCountry> AddedCountries { get; set; }
        public IEnumerable<IStoreCountry> AddedCountriesEnumerable { set => AddedCountries = value.ToList(); }


        public IList<IStoreCountry> RemovedCountries { get; set; }
        public IEnumerable<IStoreCountry> RemovedCountriesEnumerable { set => RemovedCountries = value.ToList(); }

        public StoreCountriesChangedMessagePayload()
        {
            this.Type = "StoreCountriesChanged";
        }
    }
}
