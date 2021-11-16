using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeTargetMultiBuyCustomLineItemsChangeValue : IChangeTargetMultiBuyCustomLineItemsChangeValue
    {
        public string Type { get; set; }

        public string Predicate { get; set; }

        public int TriggerQuantity { get; set; }

        public int DiscountedQuantity { get; set; }

        public int MaxOccurrence { get; set; }

        public ISelectionMode SelectionMode { get; set; }
        public ChangeTargetMultiBuyCustomLineItemsChangeValue()
        {
            this.Type = "multiBuyCustomLineItems";
        }
    }
}
