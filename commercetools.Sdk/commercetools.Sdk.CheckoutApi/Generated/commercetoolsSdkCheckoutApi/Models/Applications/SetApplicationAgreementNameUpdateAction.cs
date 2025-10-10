

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetApplicationAgreementNameUpdateAction : ISetApplicationAgreementNameUpdateAction
    {
        public string Action { get; set; }

        public string AgreementId { get; set; }

        public string Name { get; set; }
        public SetApplicationAgreementNameUpdateAction()
        {
            this.Action = "setAgreementName";
        }
    }
}
