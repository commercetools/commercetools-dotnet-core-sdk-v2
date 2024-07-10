using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAttributeChange : ISetAttributeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAttributeValue PreviousValue { get; set; }

        public IAttributeValue NextValue { get; set; }

        public string CatalogData { get; set; }
        public SetAttributeChange()
        {
            this.Type = "SetAttributeChange";
        }
    }
}
