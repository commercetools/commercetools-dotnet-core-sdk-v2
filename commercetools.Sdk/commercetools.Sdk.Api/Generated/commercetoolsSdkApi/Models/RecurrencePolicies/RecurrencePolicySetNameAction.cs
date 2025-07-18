using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicySetNameAction : IRecurrencePolicySetNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public RecurrencePolicySetNameAction()
        {
            this.Action = "setName";
        }
    }
}
