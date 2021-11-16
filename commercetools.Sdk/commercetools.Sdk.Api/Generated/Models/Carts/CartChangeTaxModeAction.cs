using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartChangeTaxModeAction : ICartChangeTaxModeAction
    {
        public string Action { get; set;}
        
        public ITaxMode TaxMode { get; set;}
        public CartChangeTaxModeAction()
        { 
           this.Action = "changeTaxMode";
        }
    }
}
