using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setMethodInfoInterface")]
    public partial class MyPaymentSetMethodInfoInterfaceAction : MyPaymentUpdateAction
    {
        public string Interface { get; set;}
        public MyPaymentSetMethodInfoInterfaceAction()
        { 
           this.Action = "setMethodInfoInterface";
        }
    }
}
