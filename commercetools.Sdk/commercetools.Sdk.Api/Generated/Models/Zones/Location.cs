using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    public partial class Location : ILocation
    {
        public string Country { get; set;}
        
        public string State { get; set;}
    }
}
