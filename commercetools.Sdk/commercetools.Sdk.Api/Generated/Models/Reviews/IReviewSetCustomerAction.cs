using commercetools.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetCustomerAction))]
    public partial interface IReviewSetCustomerAction : IReviewUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set;}
    }
}
