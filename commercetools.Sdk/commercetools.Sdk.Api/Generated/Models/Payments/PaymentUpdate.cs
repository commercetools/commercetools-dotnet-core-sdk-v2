using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentUpdate : IPaymentUpdate
    {
        public long Version { get; set; }

        public List<IPaymentUpdateAction> Actions { get; set; }
    }
}
