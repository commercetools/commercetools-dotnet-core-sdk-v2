namespace commercetools.Api.Models.CartDiscounts
{
    public partial class MultiBuyCustomLineItemsTarget : IMultiBuyCustomLineItemsTarget
    {
        public string Type { get; set; }

        public string Predicate { get; set; }

        public int TriggerQuantity { get; set; }

        public int DiscountedQuantity { get; set; }

        public int? MaxOccurrence { get; set; }

        public ISelectionMode SelectionMode { get; set; }
        public MultiBuyCustomLineItemsTarget()
        {
            this.Type = "multiBuyCustomLineItems";
        }
    }
}
