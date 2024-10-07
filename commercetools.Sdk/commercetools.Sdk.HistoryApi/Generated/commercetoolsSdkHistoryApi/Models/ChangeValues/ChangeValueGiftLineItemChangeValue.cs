using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ChangeValueGiftLineItemChangeValue : IChangeValueGiftLineItemChangeValue
    {
        public string Type { get; set; }

        public IReference Product { get; set; }

        public int VariantId { get; set; }

        public IReference SupplyChannel { get; set; }

        public IReference DistributionChannel { get; set; }
        public ChangeValueGiftLineItemChangeValue()
        {
            this.Type = "giftLineItem";
        }
    }
}
