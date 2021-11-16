namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeTargetCustomLineItemsChangeValue : IChangeTargetCustomLineItemsChangeValue
    {
        public string Type { get; set; }

        public string Predicate { get; set; }
        public ChangeTargetCustomLineItemsChangeValue()
        {
            this.Type = "customLineItems";
        }
    }
}
