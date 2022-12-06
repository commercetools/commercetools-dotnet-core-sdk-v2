using commercetools.Sdk.Api.Models.StoreCountries;
using System.Collections.Generic;
using System.Linq;


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
