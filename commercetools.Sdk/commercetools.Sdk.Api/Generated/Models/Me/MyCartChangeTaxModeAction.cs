using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeTaxMode")]
    public partial class MyCartChangeTaxModeAction : MyCartUpdateAction
    {
        public string TaxMode { get; set;}
        
        [JsonIgnore]
        public TaxMode TaxModeAsEnum => this.TaxMode.GetEnum<TaxMode>();
        public MyCartChangeTaxModeAction()
        { 
           this.Action = "changeTaxMode";
        }
    }
}
