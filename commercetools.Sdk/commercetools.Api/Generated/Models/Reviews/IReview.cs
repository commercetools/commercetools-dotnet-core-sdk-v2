using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Customers;
using commercetools.Api.Generated.Models.States;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Reviews
{
    public interface IReview : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        string UniquenessValue { get; set;}
        
        string Locale { get; set;}
        
        string AuthorName { get; set;}
        
        string Title { get; set;}
        
        string Text { get; set;}
        
        Object Target { get; set;}
        
        bool IncludedInStatistics { get; set;}
        
        int Rating { get; set;}
        
        IStateReference State { get; set;}
        
        ICustomerReference Customer { get; set;}
        
        ICustomFields Custom { get; set;}
    }
}
