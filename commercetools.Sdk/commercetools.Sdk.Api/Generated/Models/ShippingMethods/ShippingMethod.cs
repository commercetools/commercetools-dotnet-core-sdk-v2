using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethod : IShippingMethod
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public string Key { get; set;}
        
        public string Name { get; set;}
        
        public string Description { get; set;}
        
        public ILocalizedString LocalizedDescription { get; set;}
        
        public ITaxCategoryReference TaxCategory { get; set;}
        
        public List<IZoneRate> ZoneRates { get; set;}
        
        public bool IsDefault { get; set;}
        
        public string Predicate { get; set;}
        
        public ICustomFields Custom { get; set;}
    }
}
