using System;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class Counter : ICounter
    {
        public string Type { get; set; }

        public int TotalToSkip { get; set; }

        public int Skipped { get; set; }

        public DateTime? LastSkippedAt { get; set; }
        public Counter()
        {
            this.Type = "Counter";
        }
    }
}
