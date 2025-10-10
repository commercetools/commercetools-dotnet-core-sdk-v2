using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class LastModifiedBy : ILastModifiedBy
    {
        public string ClientId { get; set; }

        public string SessionId { get; set; }

        public string ExternalUserId { get; set; }

        public string AnonymousId { get; set; }

        public IReference Customer { get; set; }

        public IReference Associate { get; set; }

        public IReference User { get; set; }

        public bool? IsPlatformClient { get; set; }
    }
}
