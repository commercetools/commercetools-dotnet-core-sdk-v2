using commercetools.Api.Models.Customers;
using commercetools.Api.Models.States;
using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewDraft : IReviewDraft
    {
        public string Key { get; set;}
        
        public string UniquenessValue { get; set;}
        
        public string Locale { get; set;}
        
        public string AuthorName { get; set;}
        
        public string Title { get; set;}
        
        public string Text { get; set;}
        
        public Object Target { get; set;}
        
        public IStateResourceIdentifier State { get; set;}
        
        public int? Rating { get; set;}
        
        public ICustomerResourceIdentifier Customer { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
    }
}
