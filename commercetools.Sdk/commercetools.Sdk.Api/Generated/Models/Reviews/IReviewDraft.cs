using commercetools.Api.Models.Customers;
using commercetools.Api.Models.States;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewDraft))]
    public interface IReviewDraft 
    {
        string Key { get; set;}
        
        string UniquenessValue { get; set;}
        
        string Locale { get; set;}
        
        string AuthorName { get; set;}
        
        string Title { get; set;}
        
        string Text { get; set;}
        
        Object Target { get; set;}
        
        IStateResourceIdentifier State { get; set;}
        
        int Rating { get; set;}
        
        ICustomerResourceIdentifier Customer { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
    }
}
