using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartUpdate))]
    public partial interface ICartUpdate
    {
        long Version { get; set; }

        IList<ICartUpdateAction> Actions { get; set; }
        IEnumerable<ICartUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
