using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetSearchKeywordsChange : ISetSearchKeywordsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ISearchKeywords PreviousValue { get; set; }

        public ISearchKeywords NextValue { get; set; }

        public string CatalogData { get; set; }
        public SetSearchKeywordsChange()
        {
            this.Type = "SetSearchKeywordsChange";
        }
    }
}
