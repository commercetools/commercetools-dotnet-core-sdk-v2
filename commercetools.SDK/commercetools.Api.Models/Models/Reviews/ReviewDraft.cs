using commercetools.Api.Models.Customers;
using commercetools.Api.Models.States;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public class ReviewDraft 
    {
        public string Key { get; set;}
        
        public string UniquenessValue { get; set;}
        
        public string Locale { get; set;}
        
        public string AuthorName { get; set;}
        
        public string Title { get; set;}
        
        public string Text { get; set;}
        
        public Object Target { get; set;}
        
        public StateResourceIdentifier State { get; set;}
        
        public int Rating { get; set;}
        
        public CustomerResourceIdentifier Customer { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
    }
}
