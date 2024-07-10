using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetCountriesAction : IStoreSetCountriesAction
    {
        public string Action { get; set; }

        public IList<IStoreCountry> Countries { get; set; }
        public IEnumerable<IStoreCountry> CountriesEnumerable { set => Countries = value.ToList(); }

        public StoreSetCountriesAction()
        {
            this.Action = "setCountries";
        }
    }
}
