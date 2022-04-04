using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyPaymentDraft : IMyPaymentDraft
    {
        public IMoney AmountPlanned { get; set; }

        public IPaymentMethodInfo PaymentMethodInfo { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IMyTransactionDraft Transaction { get; set; }
    }
}
