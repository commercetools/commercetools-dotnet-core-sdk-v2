using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicySetDescriptionAction : IRecurrencePolicySetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public RecurrencePolicySetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
