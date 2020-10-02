using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("recalculate")]
    public partial class MyCartRecalculateAction : MyCartUpdateAction
    {
        public bool UpdateProductData { get; set;}
        public MyCartRecalculateAction()
        { 
           this.Action = "recalculate";
        }
    }
}
