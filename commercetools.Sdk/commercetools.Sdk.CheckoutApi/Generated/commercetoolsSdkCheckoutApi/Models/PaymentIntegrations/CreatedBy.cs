using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class CreatedBy : ICreatedBy
    {
        public string ClientId { get; set; }

        public string ExternalUserId { get; set; }

        public IReference Customer { get; set; }

        public string AnonymousId { get; set; }
    }
}
