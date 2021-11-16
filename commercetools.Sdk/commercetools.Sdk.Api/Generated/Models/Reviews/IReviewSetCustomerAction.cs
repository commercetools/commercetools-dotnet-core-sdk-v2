using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetCustomerAction))]
    public partial interface IReviewSetCustomerAction : IReviewUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set;}
    }
}
