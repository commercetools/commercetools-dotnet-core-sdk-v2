using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentSetMethodInfoInterfaceAction : IMyPaymentSetMethodInfoInterfaceAction
    {
        public string Action { get; set;}
        
        public string Interface { get; set;}
        public MyPaymentSetMethodInfoInterfaceAction()
        { 
           this.Action = "setMethodInfoInterface";
        }
    }
}
