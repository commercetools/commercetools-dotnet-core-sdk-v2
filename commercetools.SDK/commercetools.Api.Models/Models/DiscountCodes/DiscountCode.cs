using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public class DiscountCode : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public string Code { get; set;}
        
        public List<CartDiscountReference> CartDiscounts { get; set;}
        
        public string CartPredicate { get; set;}
        
        public bool IsActive { get; set;}
        
        public List<Reference> References { get; set;}
        
        public long MaxApplications { get; set;}
        
        public long MaxApplicationsPerCustomer { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public List<string> Groups { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
    }
}
