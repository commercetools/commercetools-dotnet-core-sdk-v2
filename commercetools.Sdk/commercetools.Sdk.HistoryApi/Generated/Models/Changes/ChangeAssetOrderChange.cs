using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeAssetOrderChange : IChangeAssetOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<ILocalizedString> PreviousValue { get; set; }

        public List<ILocalizedString> NextValue { get; set; }
        public ChangeAssetOrderChange()
        {
            this.Type = "ChangeAssetOrderChange";
        }
    }
}
