using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerSetSalutationAction : IMyCustomerSetSalutationAction
    {
        public string Action { get; set; }

        public string Salutation { get; set; }
        public MyCustomerSetSalutationAction()
        {
            this.Action = "setSalutation";
        }
    }
}
