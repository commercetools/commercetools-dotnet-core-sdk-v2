using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomTypeSetMessagePayload))]
    public partial interface IOrderCustomTypeSetMessagePayload : IOrderMessagePayload
    {
        ICustomFields CustomFields { get; set; }

        string PreviousTypeId { get; set; }

    }
}
