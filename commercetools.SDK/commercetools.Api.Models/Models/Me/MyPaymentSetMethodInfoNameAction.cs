using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setMethodInfoName")]
    public class MyPaymentSetMethodInfoNameAction : MyPaymentUpdateAction
    {
        public LocalizedString Name { get; set;}
    }
}
