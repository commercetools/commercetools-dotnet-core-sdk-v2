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
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPaymentDraft))]
    public interface IMyPaymentDraft 
    {
        IMoney AmountPlanned { get; set;}
        
        IPaymentMethodInfo PaymentMethodInfo { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        IMyTransactionDraft Transaction { get; set;}
    }
}
