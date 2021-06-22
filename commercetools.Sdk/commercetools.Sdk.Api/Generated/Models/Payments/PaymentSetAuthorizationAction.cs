using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetAuthorizationAction : IPaymentSetAuthorizationAction
    {
        public string Action { get; set;}
        
        public IMoney Amount { get; set;}
        
        public DateTime? Until { get; set;}
        public PaymentSetAuthorizationAction()
        { 
           this.Action = "setAuthorization";
        }
    }
}
