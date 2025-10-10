using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.CreatedBy))]
    public partial interface ICreatedBy
    {
        string ClientId { get; set; }

        string ExternalUserId { get; set; }

        IReference Customer { get; set; }

        string AnonymousId { get; set; }

    }
}
