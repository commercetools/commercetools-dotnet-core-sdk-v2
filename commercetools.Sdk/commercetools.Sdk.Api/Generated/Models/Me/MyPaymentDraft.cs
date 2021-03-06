using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


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
