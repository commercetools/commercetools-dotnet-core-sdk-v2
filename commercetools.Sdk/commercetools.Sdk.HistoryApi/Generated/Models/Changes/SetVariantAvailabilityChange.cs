using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetVariantAvailabilityChange : ISetVariantAvailabilityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public string Variant { get; set; }

        public IProductVariantAvailability PreviousValue { get; set; }

        public IProductVariantAvailability NextValue { get; set; }
        public SetVariantAvailabilityChange()
        {
            this.Type = "SetVariantAvailabilityChange";
        }
    }
}
