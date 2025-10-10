using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class ApplicationAgreement : IApplicationAgreement
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public IApplicationAgreementType Type { get; set; }

        public IApplicationAgreementStatus Status { get; set; }

        public ILocalizedString Text { get; set; }
    }
}
