using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentSetAuthorizationAction : PaymentUpdateAction
    {
        public Money Amount { get; set;}
        
        public DateTime Until { get; set;}
    }
}
