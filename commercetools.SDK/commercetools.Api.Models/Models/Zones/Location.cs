using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    public partial class Location 
    {
        public string Country { get; set;}
        
        public string State { get; set;}
    }
}
