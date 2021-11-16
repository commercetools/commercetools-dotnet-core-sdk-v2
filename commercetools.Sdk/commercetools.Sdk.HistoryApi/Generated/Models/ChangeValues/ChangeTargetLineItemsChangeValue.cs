namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeTargetLineItemsChangeValue : IChangeTargetLineItemsChangeValue
    {
        public string Type { get; set; }

        public string Predicate { get; set; }
        public ChangeTargetLineItemsChangeValue()
        {
            this.Type = "lineItems";
        }
    }
}
