using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyPaymentDraft 
    {
        public Money AmountPlanned { get; set;}
        
        public PaymentMethodInfo PaymentMethodInfo { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public MyTransactionDraft Transaction { get; set;}
    }
}
