using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Projects
{
    public partial class Project : IProject
    {
        public long Version { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public List<string> Countries { get; set; }

        public List<string> Currencies { get; set; }

        public List<string> Languages { get; set; }

        public DateTime CreatedAt { get; set; }

        public string TrialUntil { get; set; }

        public IMessageConfiguration Messages { get; set; }

        public IShippingRateInputType ShippingRateInputType { get; set; }

        public IExternalOAuth ExternalOAuth { get; set; }

        public ICartsConfiguration Carts { get; set; }

        public ISearchIndexingConfiguration SearchIndexing { get; set; }

        public IShoppingListsConfiguration ShoppingLists { get; set; }
    }
}
