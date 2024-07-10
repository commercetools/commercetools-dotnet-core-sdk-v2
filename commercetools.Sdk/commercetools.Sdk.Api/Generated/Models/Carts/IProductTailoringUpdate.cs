using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ProductTailoringUpdate))]
    public partial interface IProductTailoringUpdate
    {
        long Version { get; set; }

        IList<IProductTailoringUpdateAction> Actions { get; set; }
        IEnumerable<IProductTailoringUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
