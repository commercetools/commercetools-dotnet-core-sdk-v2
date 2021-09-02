using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
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
