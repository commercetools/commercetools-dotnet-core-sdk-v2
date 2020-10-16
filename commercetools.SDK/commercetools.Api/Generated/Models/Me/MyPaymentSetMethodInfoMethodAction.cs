using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setMethodInfoMethod")]
    public partial class MyPaymentSetMethodInfoMethodAction : MyPaymentUpdateAction
    {
        public string Method { get; set;}
        public MyPaymentSetMethodInfoMethodAction()
        { 
           this.Action = "setMethodInfoMethod";
        }
    }
}
