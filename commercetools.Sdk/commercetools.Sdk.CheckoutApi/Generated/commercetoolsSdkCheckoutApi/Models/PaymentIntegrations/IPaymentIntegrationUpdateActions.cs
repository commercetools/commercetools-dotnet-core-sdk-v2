using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationUpdateActions))]
    public partial interface IPaymentIntegrationUpdateActions
    {
        int Version { get; set; }

        IList<IPaymentIntegrationUpdateAction> Actions { get; set; }

        IEnumerable<IPaymentIntegrationUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
