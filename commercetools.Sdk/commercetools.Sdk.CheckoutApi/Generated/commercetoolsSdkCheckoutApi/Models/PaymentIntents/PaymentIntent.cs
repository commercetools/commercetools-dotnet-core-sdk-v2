using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{

    public partial class PaymentIntent : IPaymentIntent
    {
        public IList<IPaymentIntentAction> Actions { get; set; }

        public IEnumerable<IPaymentIntentAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
