using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyPaymentUpdate 
    {
        public long Version { get; set;}
        
        public List<MyPaymentUpdateAction> Actions { get; set;}
    }
}
