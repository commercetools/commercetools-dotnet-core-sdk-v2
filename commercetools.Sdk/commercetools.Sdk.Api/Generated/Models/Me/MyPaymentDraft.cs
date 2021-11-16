using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentDraft : IMyPaymentDraft
    {
        public IMoney AmountPlanned { get; set;}
        
        public IPaymentMethodInfo PaymentMethodInfo { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public IMyTransactionDraft Transaction { get; set;}
    }
}
