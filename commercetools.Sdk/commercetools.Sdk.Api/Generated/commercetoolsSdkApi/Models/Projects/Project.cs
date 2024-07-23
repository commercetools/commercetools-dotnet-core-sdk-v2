using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class Project : IProject
    {
        public long Version { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public IList<string> Countries { get; set; }
        public IEnumerable<string> CountriesEnumerable { set => Countries = value.ToList(); }


        public IList<string> Currencies { get; set; }
        public IEnumerable<string> CurrenciesEnumerable { set => Currencies = value.ToList(); }


        public IList<string> Languages { get; set; }
        public IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }


        public DateTime CreatedAt { get; set; }

        public string TrialUntil { get; set; }

        public IMessagesConfiguration Messages { get; set; }

        public ICartsConfiguration Carts { get; set; }

        public IShoppingListsConfiguration ShoppingLists { get; set; }

        public IShippingRateInputType ShippingRateInputType { get; set; }

        public IExternalOAuth ExternalOAuth { get; set; }

        public ISearchIndexingConfiguration SearchIndexing { get; set; }

        public IBusinessUnitConfiguration BusinessUnits { get; set; }
    }
}
