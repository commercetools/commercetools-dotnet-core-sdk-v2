using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerSetLocaleAction : IMyCustomerSetLocaleAction
    {
        public string Action { get; set; }

        public string Locale { get; set; }
        public MyCustomerSetLocaleAction()
        {
            this.Action = "setLocale";
        }
    }
}
