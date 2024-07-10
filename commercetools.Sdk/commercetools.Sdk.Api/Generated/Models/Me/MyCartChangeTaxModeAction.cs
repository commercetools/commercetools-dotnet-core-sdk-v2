using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartChangeTaxModeAction : IMyCartChangeTaxModeAction
    {
        public string Action { get; set; }

        public ITaxMode TaxMode { get; set; }
        public MyCartChangeTaxModeAction()
        {
            this.Action = "changeTaxMode";
        }
    }
}
