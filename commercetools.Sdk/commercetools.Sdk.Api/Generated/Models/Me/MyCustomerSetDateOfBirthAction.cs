using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerSetDateOfBirthAction : IMyCustomerSetDateOfBirthAction
    {
        public string Action { get; set; }

        public Date? DateOfBirth { get; set; }
        public MyCustomerSetDateOfBirthAction()
        {
            this.Action = "setDateOfBirth";
        }
    }
}
