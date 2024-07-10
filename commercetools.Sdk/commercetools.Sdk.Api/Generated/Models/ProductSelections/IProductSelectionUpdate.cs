using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionUpdate))]
    public partial interface IProductSelectionUpdate
    {
        long Version { get; set; }

        IList<IProductSelectionUpdateAction> Actions { get; set; }
        IEnumerable<IProductSelectionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
