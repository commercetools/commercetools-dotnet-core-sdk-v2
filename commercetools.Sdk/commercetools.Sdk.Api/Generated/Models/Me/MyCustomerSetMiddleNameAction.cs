using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerSetMiddleNameAction : IMyCustomerSetMiddleNameAction
    {
        public string Action { get; set; }

        public string MiddleName { get; set; }
        public MyCustomerSetMiddleNameAction()
        {
            this.Action = "setMiddleName";
        }
    }
}
