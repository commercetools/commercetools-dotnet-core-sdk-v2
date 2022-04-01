using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomerAction))]
    public partial interface IReviewSetCustomerAction : IReviewUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }
    }
}
