using commercetools.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.Review))]
    public partial interface IReview : IBaseResource
    {
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
        
        int? Rating { get; set;}
        
        IStateReference State { get; set;}
        
        ICustomerReference Customer { get; set;}
        
        ICustomFields Custom { get; set;}
    }
}
