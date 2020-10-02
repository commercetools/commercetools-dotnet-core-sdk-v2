using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setMethodInfoName")]
    public partial class MyPaymentSetMethodInfoNameAction : MyPaymentUpdateAction
    {
        public LocalizedString Name { get; set;}
        public MyPaymentSetMethodInfoNameAction()
        { 
           this.Action = "setMethodInfoName";
        }
    }
}
