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

    public partial class BusinessUnitAssociatesSetMessagePayload : IBusinessUnitAssociatesSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IAssociate> Associates { get; set; }
        public IEnumerable<IAssociate> AssociatesEnumerable { set => Associates = value.ToList(); }

        public BusinessUnitAssociatesSetMessagePayload()
        {
            this.Type = "BusinessUnitAssociatesSet";
        }
    }
}
