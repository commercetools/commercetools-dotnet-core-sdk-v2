using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentUpdate 
    {
        public long Version { get; set;}
        
        public List<MyPaymentUpdateAction> Actions { get; set;}
    }
}
