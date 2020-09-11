using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartAddPaymentAction : CartUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
    }
}
