using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetProductPriceCustomFieldChange : ISetProductPriceCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }

        public string CatalogData { get; set; }

        public string Variant { get; set; }

        public string PriceId { get; set; }

        public string CustomTypeId { get; set; }

        public string Name { get; set; }
        public SetProductPriceCustomFieldChange()
        {
            this.Type = "SetProductPriceCustomFieldChange";
        }
    }
}
