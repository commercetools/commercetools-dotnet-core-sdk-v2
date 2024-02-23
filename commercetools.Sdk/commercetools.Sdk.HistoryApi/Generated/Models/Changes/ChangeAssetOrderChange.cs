using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeAssetOrderChange : IChangeAssetOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<ILocalizedString> PreviousValue { get; set; }
        public IEnumerable<ILocalizedString> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<ILocalizedString> NextValue { get; set; }
        public IEnumerable<ILocalizedString> NextValueEnumerable { set => NextValue = value.ToList(); }

        public ChangeAssetOrderChange()
        {
            this.Type = "ChangeAssetOrderChange";
        }
    }
}
