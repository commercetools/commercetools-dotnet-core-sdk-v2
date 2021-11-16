using commercetools.HistoryApi.Models.Common;


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
