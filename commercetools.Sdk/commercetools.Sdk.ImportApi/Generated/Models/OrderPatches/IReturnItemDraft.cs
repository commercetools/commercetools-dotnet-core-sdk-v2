using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.ReturnItemDraft))]
    public partial interface IReturnItemDraft
    {
        long Quantity { get; set; }

        string LineItemId { get; set; }

        string CustomLineItemId { get; set; }

        string Comment { get; set; }

        IReturnShipmentState ShipmentState { get; set; }

    }
}
