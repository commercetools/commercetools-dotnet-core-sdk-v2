using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetCountriesUpdateAction : ISetCountriesUpdateAction
    {
        public string Action { get; set; }

        public IList<string> Countries { get; set; }

        public IEnumerable<string> CountriesEnumerable { set => Countries = value.ToList(); }
        public SetCountriesUpdateAction()
        {
            this.Action = "setCountries";
        }
    }
}
