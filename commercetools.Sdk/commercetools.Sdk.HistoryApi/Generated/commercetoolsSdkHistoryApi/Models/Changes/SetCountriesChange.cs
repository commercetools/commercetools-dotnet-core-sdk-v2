using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetCountriesChange : ISetCountriesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IStoreCountry> PreviousValue { get; set; }

        public IEnumerable<IStoreCountry> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IStoreCountry> NextValue { get; set; }

        public IEnumerable<IStoreCountry> NextValueEnumerable { set => NextValue = value.ToList(); }

        public IList<IStoreCountry> AddedItems { get; set; }

        public IEnumerable<IStoreCountry> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<IStoreCountry> RemovedItems { get; set; }

        public IEnumerable<IStoreCountry> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }
        public SetCountriesChange()
        {
            this.Type = "SetCountriesChange";
        }
    }
}
