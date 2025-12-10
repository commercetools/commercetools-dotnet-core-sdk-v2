using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerAddressChangedMessage : ICustomerAddressChangedMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public IAddress Address { get; set; }

        public IList<IAddressRole> AddressRoles { get; set; }

        public IEnumerable<IAddressRole> AddressRolesEnumerable { set => AddressRoles = value.ToList(); }
        public CustomerAddressChangedMessage()
        {
            this.Type = "CustomerAddressChanged";
        }
    }
}
