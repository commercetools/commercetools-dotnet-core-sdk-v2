using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartUpdate))]
    public partial interface IMyCartUpdate
    {
        long Version { get; set; }

        IList<IMyCartUpdateAction> Actions { get; set; }
        IEnumerable<IMyCartUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
