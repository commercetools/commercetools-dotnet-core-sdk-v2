using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setMethodInfoInterface")]
    public class MyPaymentSetMethodInfoInterfaceAction : MyPaymentUpdateAction
    {
        public string Interface { get; set;}
    }
}
