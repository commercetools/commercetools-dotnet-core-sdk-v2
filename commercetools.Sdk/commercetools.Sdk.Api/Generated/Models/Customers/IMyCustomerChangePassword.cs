using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.MyCustomerChangePassword))]
    public partial interface IMyCustomerChangePassword
    {
        long Version { get; set; }

        string CurrentPassword { get; set; }

        string NewPassword { get; set; }
    }
}
