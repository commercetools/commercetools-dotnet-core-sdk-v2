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
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethod))]
    public partial interface IShippingMethod : IBaseResource
    {
        new string Id { get; set;}
        
        new long Version { get; set;}
        
        new DateTime CreatedAt { get; set;}
        
        new DateTime LastModifiedAt { get; set;}
        
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
        
        ICustomFields Custom { get; set;}
    }
}
