using commercetools.Api.Models.Common;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.Zone))]
    public interface IZone : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        string Name { get; set;}
        
        string Description { get; set;}
        
        List<ILocation> Locations { get; set;}
    }
}
