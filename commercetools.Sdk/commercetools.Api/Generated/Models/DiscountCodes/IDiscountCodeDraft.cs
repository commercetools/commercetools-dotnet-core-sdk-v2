using commercetools.Api.Generated.Models.CartDiscounts;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.DiscountCodes
{
    public interface IDiscountCodeDraft 
    {
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        string Code { get; set;}
        
        List<ICartDiscountResourceIdentifier> CartDiscounts { get; set;}
        
        string CartPredicate { get; set;}
        
        bool IsActive { get; set;}
        
        long MaxApplications { get; set;}
        
        long MaxApplicationsPerCustomer { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        List<string> Groups { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
    }
}
