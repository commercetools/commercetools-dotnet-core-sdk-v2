using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class PaymentIntegrationUpdateActions : IPaymentIntegrationUpdateActions
    {
        public int Version { get; set; }

        public IList<IPaymentIntegrationUpdateAction> Actions { get; set; }

        public IEnumerable<IPaymentIntegrationUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
