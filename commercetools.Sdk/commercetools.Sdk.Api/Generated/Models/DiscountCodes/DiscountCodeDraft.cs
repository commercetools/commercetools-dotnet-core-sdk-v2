using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeDraft : IDiscountCodeDraft
    {
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public string Code { get; set;}
        
        public List<ICartDiscountResourceIdentifier> CartDiscounts { get; set;}
        
        public string CartPredicate { get; set;}
        
        public bool? IsActive { get; set;}
        
        public long? MaxApplications { get; set;}
        
        public long? MaxApplicationsPerCustomer { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public List<string> Groups { get; set;}
        
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
    }
}
