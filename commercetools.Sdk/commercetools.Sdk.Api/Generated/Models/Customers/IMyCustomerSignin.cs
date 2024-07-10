using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.MyCustomerSignin))]
    public partial interface IMyCustomerSignin
    {
        string Email { get; set; }

        string Password { get; set; }

        IAnonymousCartSignInMode ActiveCartSignInMode { get; set; }

        bool? UpdateProductData { get; set; }

    }
}
