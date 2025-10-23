using commercetools.Sdk.HistoryApi.Models.Common;
using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class AddPriceChange : IAddPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IPrice NextValue { get; set; }

        public string CatalogData { get; set; }

        public string PriceId { get; set; }

        public string Variant { get; set; }
        public AddPriceChange()
        {
            this.Type = "AddPriceChange";
        }
    }
}
