using commercetools.Sdk.HistoryApi.Models.Common;
using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class RemovePriceChange : IRemovePriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IPrice PreviousValue { get; set; }

        public IPrice NextValue { get; set; }

        public string CatalogData { get; set; }

        public string PriceId { get; set; }

        public string Variant { get; set; }
        public RemovePriceChange()
        {
            this.Type = "RemovePriceChange";
        }
    }
}
