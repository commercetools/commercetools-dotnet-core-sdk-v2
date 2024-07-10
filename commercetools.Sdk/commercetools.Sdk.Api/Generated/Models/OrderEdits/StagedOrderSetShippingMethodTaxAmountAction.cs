using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingMethodTaxAmountAction : IStagedOrderSetShippingMethodTaxAmountAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
        public StagedOrderSetShippingMethodTaxAmountAction()
        {
            this.Action = "setShippingMethodTaxAmount";
        }
    }
}
