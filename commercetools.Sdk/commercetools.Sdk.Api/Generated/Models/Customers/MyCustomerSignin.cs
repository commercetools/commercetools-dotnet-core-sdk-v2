using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class MyCustomerSignin : IMyCustomerSignin
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public IAnonymousCartSignInMode ActiveCartSignInMode { get; set; }

        public bool? UpdateProductData { get; set; }
    }
}
