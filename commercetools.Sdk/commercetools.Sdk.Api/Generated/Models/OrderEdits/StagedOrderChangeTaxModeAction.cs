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

    public partial class StagedOrderChangeTaxModeAction : IStagedOrderChangeTaxModeAction
    {
        public string Action { get; set; }

        public ITaxMode TaxMode { get; set; }
        public StagedOrderChangeTaxModeAction()
        {
            this.Action = "changeTaxMode";
        }
    }
}
