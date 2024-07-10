using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCountriesAction))]
    public partial interface IStoreSetCountriesAction : IStoreUpdateAction
    {
        IList<IStoreCountry> Countries { get; set; }
        IEnumerable<IStoreCountry> CountriesEnumerable { set => Countries = value.ToList(); }


    }
}
