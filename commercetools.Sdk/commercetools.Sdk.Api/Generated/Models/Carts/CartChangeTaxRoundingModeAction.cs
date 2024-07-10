using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartChangeTaxRoundingModeAction : ICartChangeTaxRoundingModeAction
    {
        public string Action { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }
        public CartChangeTaxRoundingModeAction()
        {
            this.Action = "changeTaxRoundingMode";
        }
    }
}
