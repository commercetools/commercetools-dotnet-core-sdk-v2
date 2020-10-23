using commercetools.Api.Generated.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Payments
{
    public interface IPaymentChangeTransactionInteractionIdAction : IPaymentUpdateAction
    {
        string TransactionId { get; set;}
        
        string InteractionId { get; set;}
    }
}
