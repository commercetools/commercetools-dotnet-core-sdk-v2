using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("changeName")]
    public partial class ZoneChangeNameAction : ZoneUpdateAction
    {
        public string Name { get; set;}
        public ZoneChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
