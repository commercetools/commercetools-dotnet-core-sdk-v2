

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetApplicationAgreementStatusUpdateAction : ISetApplicationAgreementStatusUpdateAction
    {
        public string Action { get; set; }

        public string AgreementId { get; set; }

        public IApplicationAgreementStatus Status { get; set; }
        public SetApplicationAgreementStatusUpdateAction()
        {
            this.Action = "setAgreementStatus";
        }
    }
}
