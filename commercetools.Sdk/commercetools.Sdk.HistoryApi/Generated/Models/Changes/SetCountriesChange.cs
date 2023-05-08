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

        public SetCountriesChange()
        {
            this.Type = "SetCountriesChange";
        }
    }
}
