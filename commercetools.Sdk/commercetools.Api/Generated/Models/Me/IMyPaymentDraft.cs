using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Me;
using commercetools.Api.Generated.Models.Payments;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyPaymentDraft 
    {
        IMoney AmountPlanned { get; set;}
        
        IPaymentMethodInfo PaymentMethodInfo { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        IMyTransactionDraft Transaction { get; set;}
    }
}
