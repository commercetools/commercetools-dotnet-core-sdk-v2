using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.StoreCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCountriesChangedMessagePayload))]
    public partial interface IStoreCountriesChangedMessagePayload : IMessagePayload
    {
        IList<IStoreCountry> AddedCountries { get; set; }
        IEnumerable<IStoreCountry> AddedCountriesEnumerable { set => AddedCountries = value.ToList(); }


        IList<IStoreCountry> RemovedCountries { get; set; }
        IEnumerable<IStoreCountry> RemovedCountriesEnumerable { set => RemovedCountries = value.ToList(); }


    }
}
