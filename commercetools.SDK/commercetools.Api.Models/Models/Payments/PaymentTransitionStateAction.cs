using commercetools.Api.Models.Payments;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("transitionState")]
    public partial class PaymentTransitionStateAction : PaymentUpdateAction
    {
        public StateResourceIdentifier State { get; set;}
        
        public bool Force { get; set;}
        public PaymentTransitionStateAction()
        { 
           this.Action = "transitionState";
        }
    }
}
