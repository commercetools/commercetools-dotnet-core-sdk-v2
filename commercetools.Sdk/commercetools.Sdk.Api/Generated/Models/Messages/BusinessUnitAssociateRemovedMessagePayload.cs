using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAssociateRemovedMessagePayload : IBusinessUnitAssociateRemovedMessagePayload
    {
        public string Type { get; set; }

        public IAssociate Associate { get; set; }
        public BusinessUnitAssociateRemovedMessagePayload()
        {
            this.Type = "BusinessUnitAssociateRemoved";
        }
    }
}
