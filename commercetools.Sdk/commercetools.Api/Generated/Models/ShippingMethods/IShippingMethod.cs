using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ShippingMethods;
using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShippingMethods
{
    [DeserializeAs(typeof(ShippingMethod))]
    public interface IShippingMethod : IBaseResource
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
        
        ILocalizedString LocalizedDescription { get; set;}
        
        ITaxCategoryReference TaxCategory { get; set;}
        
        List<IZoneRate> ZoneRates { get; set;}
        
        bool IsDefault { get; set;}
        
        string Predicate { get; set;}
    }
}
