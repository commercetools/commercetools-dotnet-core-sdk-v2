using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("setDescription")]
    public partial class ZoneSetDescriptionAction : ZoneUpdateAction
    {
        public string Description { get; set;}
        public ZoneSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
