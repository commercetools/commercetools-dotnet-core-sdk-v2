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

    public partial class StagedOrderChangeTaxRoundingModeAction : IStagedOrderChangeTaxRoundingModeAction
    {
        public string Action { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }
        public StagedOrderChangeTaxRoundingModeAction()
        {
            this.Action = "changeTaxRoundingMode";
        }
    }
}
