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

    public partial class StoreRemoveCountryAction : IStoreRemoveCountryAction
    {
        public string Action { get; set; }

        public IStoreCountry Country { get; set; }
        public StoreRemoveCountryAction()
        {
            this.Action = "removeCountry";
        }
    }
}
