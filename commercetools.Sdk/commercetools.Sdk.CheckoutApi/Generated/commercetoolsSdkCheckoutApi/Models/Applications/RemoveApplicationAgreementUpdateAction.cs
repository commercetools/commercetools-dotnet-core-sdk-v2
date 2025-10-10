

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class RemoveApplicationAgreementUpdateAction : IRemoveApplicationAgreementUpdateAction
    {
        public string Action { get; set; }

        public string AgreementId { get; set; }
        public RemoveApplicationAgreementUpdateAction()
        {
            this.Action = "removeAgreement";
        }
    }
}
