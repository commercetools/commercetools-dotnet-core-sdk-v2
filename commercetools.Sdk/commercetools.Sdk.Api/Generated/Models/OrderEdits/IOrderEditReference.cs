using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditReference))]
    public partial interface IOrderEditReference : IReference
    {
        IOrderEdit Obj { get; set; }

        new string Id { get; set; }

    }
}
