using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerAction))]
    public partial interface IDiscountCodeSetMaxApplicationsPerCustomerAction : IDiscountCodeUpdateAction
    {
        long? MaxApplicationsPerCustomer { get; set; }

    }
}
