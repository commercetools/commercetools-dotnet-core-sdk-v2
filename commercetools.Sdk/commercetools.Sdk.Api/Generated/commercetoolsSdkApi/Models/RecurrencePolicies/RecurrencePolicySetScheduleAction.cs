

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicySetScheduleAction : IRecurrencePolicySetScheduleAction
    {
        public string Action { get; set; }

        public IRecurrencePolicyScheduleDraft Schedule { get; set; }
        public RecurrencePolicySetScheduleAction()
        {
            this.Action = "setSchedule";
        }
    }
}
