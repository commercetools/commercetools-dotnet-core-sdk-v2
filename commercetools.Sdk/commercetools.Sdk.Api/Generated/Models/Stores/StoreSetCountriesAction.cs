using commercetools.Sdk.Api.Models.StoreCountries;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreSetCountriesAction : IStoreSetCountriesAction
    {
        public string Action { get; set; }

        public List<IStoreCountry> Countries { get; set; }
        public StoreSetCountriesAction()
        {
            this.Action = "setCountries";
        }
    }
}
