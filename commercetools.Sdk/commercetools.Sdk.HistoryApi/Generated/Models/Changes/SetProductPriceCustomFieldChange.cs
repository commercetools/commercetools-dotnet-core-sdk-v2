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

    public partial class SetProductPriceCustomFieldChange : ISetProductPriceCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }

        public string CatalogData { get; set; }
        public SetProductPriceCustomFieldChange()
        {
            this.Type = "SetProductPriceCustomFieldChange";
        }
    }
}
