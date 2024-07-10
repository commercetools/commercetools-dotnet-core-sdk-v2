using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddPaymentAction : ICartAddPaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public CartAddPaymentAction()
        {
            this.Action = "addPayment";
        }
    }
}
