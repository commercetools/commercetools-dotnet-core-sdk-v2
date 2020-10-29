using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.Location))]
    public interface ILocation 
    {
        string Country { get; set;}
        
        string State { get; set;}
    }
}
