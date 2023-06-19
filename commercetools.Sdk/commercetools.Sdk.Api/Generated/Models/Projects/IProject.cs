using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.Project))]
    public partial interface IProject
    {
        long Version { get; set; }

        string Key { get; set; }

        string Name { get; set; }

        IList<string> Countries { get; set; }
        IEnumerable<string> CountriesEnumerable { set => Countries = value.ToList(); }


        IList<string> Currencies { get; set; }
        IEnumerable<string> CurrenciesEnumerable { set => Currencies = value.ToList(); }


        IList<string> Languages { get; set; }
        IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }


        DateTime CreatedAt { get; set; }

        string TrialUntil { get; set; }

        IMessagesConfiguration Messages { get; set; }

        ICartsConfiguration Carts { get; set; }

        IShoppingListsConfiguration ShoppingLists { get; set; }

        IShippingRateInputType ShippingRateInputType { get; set; }

        IExternalOAuth ExternalOAuth { get; set; }

        ISearchIndexingConfiguration SearchIndexing { get; set; }

        IBusinessUnitConfiguration BusinessUnits { get; set; }

    }
}
