

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicySetMinDaysBetweenOrdersAction : IRecurrencePolicySetMinDaysBetweenOrdersAction
    {
        public string Action { get; set; }

        public int? MinDaysBetweenOrders { get; set; }
        public RecurrencePolicySetMinDaysBetweenOrdersAction()
        {
            this.Action = "setMinDaysBetweenOrders";
        }
    }
}
