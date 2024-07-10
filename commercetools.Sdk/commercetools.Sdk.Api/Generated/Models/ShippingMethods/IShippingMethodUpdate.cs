using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodUpdate))]
    public partial interface IShippingMethodUpdate
    {
        long Version { get; set; }

        IList<IShippingMethodUpdateAction> Actions { get; set; }
        IEnumerable<IShippingMethodUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
