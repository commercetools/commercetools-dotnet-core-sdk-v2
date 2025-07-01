using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodUpdate : IPaymentMethodUpdate
    {
        public long Version { get; set; }

        public IList<IPaymentMethodUpdateAction> Actions { get; set; }

        public IEnumerable<IPaymentMethodUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
