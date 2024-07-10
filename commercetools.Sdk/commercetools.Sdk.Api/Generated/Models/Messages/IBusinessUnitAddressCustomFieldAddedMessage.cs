using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAddressCustomFieldAddedMessage))]
    public partial interface IBusinessUnitAddressCustomFieldAddedMessage : IMessage
    {
        string Name { get; set; }

        Object Value { get; set; }

        string AddressId { get; set; }

    }
}
