using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartChangeTaxCalculationModeAction : ICartChangeTaxCalculationModeAction
    {
        public string Action { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }
        public CartChangeTaxCalculationModeAction()
        {
            this.Action = "changeTaxCalculationMode";
        }
    }
}
