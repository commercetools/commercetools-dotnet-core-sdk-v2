using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressRemovedMessage))]
    public partial interface IBusinessUnitAddressRemovedMessage : IMessage
    {
        IAddress Address { get; set; }

        IList<IAddressRole> AddressRoles { get; set; }

        IEnumerable<IAddressRole> AddressRolesEnumerable { set => AddressRoles = value.ToList(); }

    }
}
