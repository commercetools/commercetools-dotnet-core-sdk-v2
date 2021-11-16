using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewResourceIdentifier : IReviewResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public string Key { get; set;}
        public ReviewResourceIdentifier()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("review");
        }
    }
}
