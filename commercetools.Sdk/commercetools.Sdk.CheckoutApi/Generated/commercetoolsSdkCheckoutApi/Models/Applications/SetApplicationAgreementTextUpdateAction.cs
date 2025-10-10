using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetApplicationAgreementTextUpdateAction : ISetApplicationAgreementTextUpdateAction
    {
        public string Action { get; set; }

        public string AgreementId { get; set; }

        public ILocalizedString Text { get; set; }
        public SetApplicationAgreementTextUpdateAction()
        {
            this.Action = "setAgreementText";
        }
    }
}
