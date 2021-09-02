using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetAssetTagsChange : ISetAssetTagsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAssetChangeValue Asset { get; set; }

        public List<string> NextValue { get; set; }

        public List<string> PreviousValue { get; set; }
        public SetAssetTagsChange()
        {
            this.Type = "SetAssetTagsChange";
        }
    }
}
