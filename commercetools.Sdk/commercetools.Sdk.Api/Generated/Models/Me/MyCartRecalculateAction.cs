using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartRecalculateAction : IMyCartRecalculateAction
    {
        public string Action { get; set; }

        public bool? UpdateProductData { get; set; }
        public MyCartRecalculateAction()
        {
            this.Action = "recalculate";
        }
    }
}
