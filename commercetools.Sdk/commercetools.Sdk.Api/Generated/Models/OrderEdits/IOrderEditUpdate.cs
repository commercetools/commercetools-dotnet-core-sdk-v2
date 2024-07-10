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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditUpdate))]
    public partial interface IOrderEditUpdate
    {
        long Version { get; set; }

        IList<IOrderEditUpdateAction> Actions { get; set; }
        IEnumerable<IOrderEditUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


        bool? DryRun { get; set; }

    }
}
