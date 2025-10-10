

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetApplicationAgreementTypeUpdateAction : ISetApplicationAgreementTypeUpdateAction
    {
        public string Action { get; set; }

        public string AgreementId { get; set; }

        public IApplicationAgreementType Type { get; set; }
        public SetApplicationAgreementTypeUpdateAction()
        {
            this.Action = "setAgreementType";
        }
    }
}
