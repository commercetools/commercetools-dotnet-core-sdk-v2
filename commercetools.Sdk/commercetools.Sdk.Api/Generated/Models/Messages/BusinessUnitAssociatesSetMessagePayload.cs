using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;
using System.Linq;


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
