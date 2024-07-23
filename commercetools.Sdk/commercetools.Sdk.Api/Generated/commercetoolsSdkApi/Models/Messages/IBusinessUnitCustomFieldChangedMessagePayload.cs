using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomFieldChangedMessagePayload))]
    public partial interface IBusinessUnitCustomFieldChangedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

        Object Value { get; set; }

        Object OldValue { get; set; }

    }
}
