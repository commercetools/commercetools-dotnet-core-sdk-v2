using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitRemoveAssociateAction : IMyBusinessUnitRemoveAssociateAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public MyBusinessUnitRemoveAssociateAction()
        {
            this.Action = "removeAssociate";
        }
    }
}
