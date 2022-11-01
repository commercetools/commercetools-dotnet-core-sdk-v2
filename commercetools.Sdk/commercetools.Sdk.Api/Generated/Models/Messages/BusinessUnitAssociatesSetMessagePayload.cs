using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAssociatesSetMessagePayload : IBusinessUnitAssociatesSetMessagePayload
    {
        public string Type { get; set; }

        public List<IAssociate> Associates { get; set; }
        public BusinessUnitAssociatesSetMessagePayload()
        {
            this.Type = "BusinessUnitAssociatesSet";
        }
    }
}
