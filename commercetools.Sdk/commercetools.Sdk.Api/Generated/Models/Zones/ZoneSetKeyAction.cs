using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("setKey")]
    public partial class ZoneSetKeyAction : ZoneUpdateAction
    {
        public string Key { get; set;}
        public ZoneSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
