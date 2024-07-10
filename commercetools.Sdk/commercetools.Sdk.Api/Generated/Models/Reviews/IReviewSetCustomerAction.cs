using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomerAction))]
    public partial interface IReviewSetCustomerAction : IReviewUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }

    }
}
