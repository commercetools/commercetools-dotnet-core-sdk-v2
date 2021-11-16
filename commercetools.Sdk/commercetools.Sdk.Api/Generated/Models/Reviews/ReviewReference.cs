using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewReference : IReviewReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IReview Obj { get; set; }
        public ReviewReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("review");
        }
    }
}
