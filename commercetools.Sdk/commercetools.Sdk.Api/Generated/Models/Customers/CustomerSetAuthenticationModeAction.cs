using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetAuthenticationModeAction : ICustomerSetAuthenticationModeAction
    {
        public string Action { get; set; }

        public IAuthenticationMode AuthMode { get; set; }

        public string Password { get; set; }
        public CustomerSetAuthenticationModeAction()
        {
            this.Action = "setAuthenticationMode";
        }
    }
}
