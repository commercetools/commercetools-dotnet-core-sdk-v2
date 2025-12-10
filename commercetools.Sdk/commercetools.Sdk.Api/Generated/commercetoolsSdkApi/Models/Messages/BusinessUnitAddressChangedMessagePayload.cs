using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressChangedMessagePayload : IBusinessUnitAddressChangedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }

        public IList<IAddressRole> AddressRoles { get; set; }

        public IEnumerable<IAddressRole> AddressRolesEnumerable { set => AddressRoles = value.ToList(); }
        public BusinessUnitAddressChangedMessagePayload()
        {
            this.Type = "BusinessUnitAddressChanged";
        }
    }
}
