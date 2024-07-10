using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerResetPassword : ICustomerResetPassword
    {
        public string TokenValue { get; set; }

        public string NewPassword { get; set; }

        public long? Version { get; set; }
    }
}
