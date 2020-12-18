using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartUpdate : IMyCartUpdate
    {
        public long Version { get; set;}
        
        public List<IMyCartUpdateAction> Actions { get; set;}
    }
}
