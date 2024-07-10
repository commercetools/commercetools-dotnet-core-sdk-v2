using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Update))]
    public partial interface IUpdate
    {
        long Version { get; set; }

        IList<IUpdateAction> Actions { get; set; }
        IEnumerable<IUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
