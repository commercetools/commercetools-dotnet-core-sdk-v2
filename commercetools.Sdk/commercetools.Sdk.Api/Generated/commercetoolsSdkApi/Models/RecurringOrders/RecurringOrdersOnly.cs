

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrdersOnly : IRecurringOrdersOnly
    {
        public string Type { get; set; }
        public RecurringOrdersOnly()
        {
            this.Type = "RecurringOrdersOnly";
        }
    }
}
