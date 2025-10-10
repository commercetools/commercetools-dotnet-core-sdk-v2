

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class AddApplicationAgreementUpdateAction : IAddApplicationAgreementUpdateAction
    {
        public string Action { get; set; }

        public IApplicationAgreementDraft Agreement { get; set; }
        public AddApplicationAgreementUpdateAction()
        {
            this.Action = "addAgreement";
        }
    }
}
