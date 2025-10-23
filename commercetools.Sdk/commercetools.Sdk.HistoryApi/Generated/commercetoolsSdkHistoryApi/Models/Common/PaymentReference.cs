

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class PaymentReference : IPaymentReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public PaymentReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("payment");
        }
    }
}
