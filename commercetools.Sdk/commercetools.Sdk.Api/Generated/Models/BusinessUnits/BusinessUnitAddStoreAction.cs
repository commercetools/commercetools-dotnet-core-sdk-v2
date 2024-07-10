using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAddStoreAction : IBusinessUnitAddStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public BusinessUnitAddStoreAction()
        {
            this.Action = "addStore";
        }
    }
}
