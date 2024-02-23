using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StoreCountries;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreCountriesChangedMessage : IStoreCountriesChangedMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public IList<IStoreCountry> AddedCountries { get; set; }
        public IEnumerable<IStoreCountry> AddedCountriesEnumerable { set => AddedCountries = value.ToList(); }


        public IList<IStoreCountry> RemovedCountries { get; set; }
        public IEnumerable<IStoreCountry> RemovedCountriesEnumerable { set => RemovedCountries = value.ToList(); }

        public StoreCountriesChangedMessage()
        {
            this.Type = "StoreCountriesChanged";
        }
    }
}
