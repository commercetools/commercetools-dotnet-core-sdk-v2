using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.States;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public class Review : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public string Key { get; set;}
        
        public string UniquenessValue { get; set;}
        
        public string Locale { get; set;}
        
        public string AuthorName { get; set;}
        
        public string Title { get; set;}
        
        public string Text { get; set;}
        
        public Object Target { get; set;}
        
        public bool IncludedInStatistics { get; set;}
        
        public int Rating { get; set;}
        
        public StateReference State { get; set;}
        
        public CustomerReference Customer { get; set;}
        
        public CustomFields Custom { get; set;}
    }
}
