using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ShippingMethodSetLocalizedDescriptionChange : IShippingMethodSetLocalizedDescriptionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString PreviousValue { get; set; }

        public ILocalizedString NextValue { get; set; }
        public ShippingMethodSetLocalizedDescriptionChange()
        {
            this.Type = "ShippingMethodSetLocalizedDescriptionChange";
        }
    }
}
