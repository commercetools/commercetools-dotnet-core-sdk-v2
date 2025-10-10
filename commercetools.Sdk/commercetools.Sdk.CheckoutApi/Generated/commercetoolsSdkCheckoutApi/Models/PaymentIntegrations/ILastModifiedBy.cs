using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.LastModifiedBy))]
    public partial interface ILastModifiedBy
    {
        string ClientId { get; set; }

        string SessionId { get; set; }

        string ExternalUserId { get; set; }

        string AnonymousId { get; set; }

        IReference Customer { get; set; }

        IReference Associate { get; set; }

        IReference User { get; set; }

        bool? IsPlatformClient { get; set; }

    }
}
