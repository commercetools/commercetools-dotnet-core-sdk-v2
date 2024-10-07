

namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class PaymentKeyReference : IPaymentKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public PaymentKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("payment");
        }
    }
}
