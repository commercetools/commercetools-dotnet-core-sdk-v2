

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class CounterDraft : ICounterDraft
    {
        public string Type { get; set; }

        public int TotalToSkip { get; set; }
        public CounterDraft()
        {
            this.Type = "counter";
        }
    }
}
