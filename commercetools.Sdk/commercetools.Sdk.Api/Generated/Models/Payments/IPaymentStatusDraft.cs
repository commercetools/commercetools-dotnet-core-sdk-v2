using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentStatusDraft))]
    public partial interface IPaymentStatusDraft 
    {
        string InterfaceCode { get; set;}
        
        string InterfaceText { get; set;}
        
        IStateResourceIdentifier State { get; set;}
    }
}
