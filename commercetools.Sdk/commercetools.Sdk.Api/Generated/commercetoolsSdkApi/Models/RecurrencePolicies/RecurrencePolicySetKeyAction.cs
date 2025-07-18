

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicySetKeyAction : IRecurrencePolicySetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public RecurrencePolicySetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
