using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerChangePassword : ICustomerChangePassword
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
